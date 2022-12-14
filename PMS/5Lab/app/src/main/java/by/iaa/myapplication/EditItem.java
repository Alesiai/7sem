package by.iaa.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TimePicker;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStream;
import java.util.Calendar;
import java.util.GregorianCalendar;

import by.iaa.myapplication.Models.*;

public class EditItem extends AppCompatActivity {
    Item item;
    ImageView imageView;
    EditText name, description;
    DatePicker date;
    TimePicker time;
    private final int Pick_image = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit_item);
        item = (Item) getIntent().getExtras().getSerializable("item");

        imageView = findViewById(R.id.image);
        name = findViewById(R.id.name);
        description = findViewById(R.id.description);
        date = findViewById(R.id.calendar);
        time = findViewById(R.id.time);

        Image.getInstance().loadImageFromStorage(imageView, item.pathImages);
        name.setText(item.name);
        description.setText(item.description);
        date.updateDate(item.calendar.get(Calendar.YEAR),
                item.calendar.get(Calendar.MONTH),
                item.calendar.get(Calendar.DATE));
        time.setHour(item.calendar.get(Calendar.HOUR));
        time.setMinute(item.calendar.get(Calendar.MINUTE));
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.save_changes, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.save:
                changeItem();
                goToMainActivity();
                return true;
            case R.id.cancel:
                goToMainActivity();
                return true;
            default:
                return true;
        }
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
            imageView.setImageBitmap(selectedImage);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }

    public void goToMainActivity() {
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }

    public void changeItem() {
        ItemList eventsList = new ItemList(this);
        eventsList.RemoveItem(item);
        item.name = name.getText().toString();
        item.description = description.getText().toString();
        item.calendar = new GregorianCalendar(date.getYear(), date.getMonth(), date.getDayOfMonth(),
                time.getHour(), time.getMinute());
        try {
            item.pathImages = Image.getInstance().saveToInternalStorage(
                    ((BitmapDrawable) imageView.getDrawable()).getBitmap(), this, item.getNameImage());
        } catch (IOException exception) {
            exception.printStackTrace();
        }
        eventsList.AddItem(item);
    }
}