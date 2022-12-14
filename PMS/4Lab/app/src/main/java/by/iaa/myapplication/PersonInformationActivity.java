package by.iaa.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class PersonInformationActivity extends AppCompatActivity {
    TextView name, university, date, phone, email, link;
    Person item;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_person_information);

        Bundle bundle = getIntent().getExtras();
        item = (Person) bundle.getSerializable("person");

        name = findViewById(R.id.name);
        university = findViewById(R.id.university);
        date = findViewById(R.id.date);
        phone = findViewById(R.id.phone);
        email = findViewById(R.id.email);
        link = findViewById(R.id.link);

        name.setText(item.getName());
        university.setText(item.getUniversity());
        date.setText(item.getStringDate());
        phone.setText(item.getPhone());
        email.setText(item.getEmail());
        link.setText(item.getLink());

    }

    public void goPhone(View v) {
        Intent intent = new Intent(Intent.ACTION_DIAL,
                Uri.parse("tel:" + phone.getText().toString()));
        if (intent.resolveActivity(getPackageManager()) != null) {
            startActivity(intent);
        }
        startActivity(intent);
    }

    public void goEmail(View v) {
        final Intent emailIntent = new Intent(Intent.ACTION_SEND);

        emailIntent.setType("plain/text");
        emailIntent.putExtra(Intent.EXTRA_EMAIL, new String[]{email.getText().toString()});
        emailIntent.putExtra(Intent.EXTRA_SUBJECT, "Main Theme");
        emailIntent.putExtra(Intent.EXTRA_TEXT, "Email text");

        startActivity(Intent.createChooser(emailIntent, "Send mail..."));
    }

    public void goSocialNet(View v) {
        Intent intent = new Intent(Intent.ACTION_VIEW, Uri.parse("http://www." + item.getLink()));
        startActivity(intent);
    }

    public void back(View v) {
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }
}