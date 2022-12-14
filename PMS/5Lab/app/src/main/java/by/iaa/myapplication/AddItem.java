package by.iaa.myapplication;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.Bundle;

import androidx.appcompat.app.AppCompatActivity;

import android.view.*;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TimePicker;

import java.io.FileNotFoundException;
import java.io.InputStream;
import java.util.Calendar;
import java.util.GregorianCalendar;

import by.iaa.myapplication.Models.*;

public class AddItem extends AppCompatActivity {

    TimePicker time;

    DatePicker date;
    ImageView imageView;
    EditText name, description;


    private final int Pick_image = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_item);

        time = findViewById(R.id.time);
        date = findViewById(R.id.calendar);
        imageView = findViewById(R.id.image);
        name = findViewById(R.id.name);
        description = findViewById(R.id.description);
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
                addItem();
                return true;
            default:
                return true;
        }
    }

    public void uploadImage(View v) {
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

    public void addItem() {
        Calendar calendar = new GregorianCalendar(date.getYear(), date.getMonth(), date.getDayOfMonth(),
                time.getHour(), time.getMinute());
        Item item = new Item(name.getText().toString(), description.getText().toString(), calendar);
        try {
            item.pathImages = Image.getInstance().
                    saveToInternalStorage(((BitmapDrawable) imageView.getDrawable()).getBitmap(),
                            this, item.getNameImage());
        } catch (Exception e) {
            e.printStackTrace();
        }
        ItemList eventsList = new ItemList(this);
        eventsList.AddItem(item);
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }
}