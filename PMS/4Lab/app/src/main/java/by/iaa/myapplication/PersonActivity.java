package by.iaa.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.app.DatePickerDialog;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import java.io.FileNotFoundException;
import java.io.InputStream;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.List;

public class PersonActivity extends AppCompatActivity {
    private final int Pick_image = 1;
    List<Person> personList;
    EditText name, university, phone, email, link;
    TextView date;
    Calendar calendar;
    ImageView photo;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_person);

        calendar = new GregorianCalendar();

        name = findViewById(R.id.name);
        university = findViewById(R.id.university);
        date = findViewById(R.id.date);
        photo = findViewById(R.id.photo);
        phone=findViewById(R.id.phone);
        email =findViewById(R.id.email);
        link=findViewById(R.id.link);

        personList = JsonHelper.importFromJSON(this);

        if (personList == null)
            personList = new ArrayList<>();

        setDateCreate();

    }

    public void setDate(View v) {
        new DatePickerDialog(PersonActivity.this, d,
                calendar.get(Calendar.YEAR),
                calendar.get(Calendar.MONTH),
                calendar.get(Calendar.DAY_OF_MONTH)).show();
    }

    DatePickerDialog.OnDateSetListener d = new DatePickerDialog.OnDateSetListener() {
        public void onDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth) {
            calendar.set(Calendar.YEAR, year);
            calendar.set(Calendar.MONTH, monthOfYear);
            calendar.set(Calendar.DAY_OF_MONTH, dayOfMonth);
            setDateCreate();
        }
    };

    @SuppressLint("SetTextI18n")
    public void setDateCreate() {
        date.setText(getStringCalendar());
    }

    public void save(View v) {
        Person person = new Person(name.getText().toString(),
                calendar,
                university.getText().toString(),
                phone.getText().toString(),
                email.getText().toString(),
                link.getText().toString()
        );

        if (personList.contains(person)) {
            Toast.makeText(this, "Такой объект уже существует", Toast.LENGTH_LONG).show();
            return;
        }

        personList.add(person);
        if (JsonHelper.exportToJSON(this, personList))
            Toast.makeText(this, "Сохранено", Toast.LENGTH_SHORT).show();
        else
            Toast.makeText(this, "Не удалось сохранить", Toast.LENGTH_SHORT).show();
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }

    public String getStringCalendar() {
        int day = calendar.get(Calendar.DATE);
        int month = calendar.get(Calendar.MONTH) + 1;
        int year = calendar.get(Calendar.YEAR);
        return (day < 10 ? "0" + day : day) + "." +
                (month < 10 ? "0" + month : month) + "." +
                year;
    }

    public void setImage(View v) {
        Intent intent = new Intent(Intent.ACTION_PICK);
        intent.setType("image/*");
        startActivityForResult(intent, Pick_image);
    }

    protected void onActivityResult(int requestCode, int resultCode, Intent imageReturnedIntent) {
        super.onActivityResult(requestCode, resultCode, imageReturnedIntent);

        try {
            final Uri imageUri = imageReturnedIntent.getData();
            final InputStream imageStream = getContentResolver().openInputStream(imageUri);
            Bitmap selectedImage = BitmapFactory.decodeStream(imageStream);
            photo.setImageBitmap(selectedImage);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }
}