package by.iaa.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.os.Environment;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;


import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

import by.iaa.myapplication.helpers.RequestPermissions;


public class MainActivity4 extends AppCompatActivity {
    //region Initialization
    Button backToEducationActivityButton;
    Button confirmButton;
    TextView confirmFirstNameTextView, confirmMiddleNameTextView, confirmLastNameTextView,
            confirmBirthPlaceTextView, confirmBirthDateTextView, confirmUniversityTextView,
            confirmCourseTextView, confirmSpecializationTextView;
    String firstName, middleName, lastName, birthPlace, birthDate, university, specialization, course;
    Context context = this;
    Activity activity = this;
    //endregion
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main4);
        //region findViewById()
        confirmFirstNameTextView = findViewById(R.id.confirmFirstNameTextView);
        confirmMiddleNameTextView = findViewById(R.id.confirmMiddleNameTextView);
        confirmLastNameTextView = findViewById(R.id.confirmLastNameTextView);
        confirmBirthPlaceTextView = findViewById(R.id.confirmBirthPlaceTextView);
        confirmBirthDateTextView = findViewById(R.id.confirmBirthDateTextView);
        confirmUniversityTextView = findViewById(R.id.confirmUniversityTextView);
        confirmCourseTextView = findViewById(R.id.confirmCourseTextView);
        confirmSpecializationTextView = findViewById(R.id.confirmSpecializationTextView);
        confirmButton = findViewById(R.id.confirmButton);
        backToEducationActivityButton = findViewById(R.id.backToEducationActivityButton);
        //endregion()

        //region Bundle
        Bundle bundle = getIntent().getBundleExtra("person");
        firstName = bundle.getString("firstName");
        middleName = bundle.getString("middleName");
        lastName = bundle.getString("lastName");
        birthPlace = bundle.getString("birthPlace");
        birthDate = bundle.getString("birthDate");
        university = bundle.getString("university");
        course = bundle.getString("fack");
        specialization = bundle.getString("specialization");
        //endregion

        //region setText()
        confirmFirstNameTextView.setText("Имя: " + firstName);
        confirmMiddleNameTextView.setText("Фамилимя: " + middleName);
        confirmLastNameTextView.setText("Отчество: " + lastName);
        confirmBirthPlaceTextView.setText("Дата рождения: " + birthDate);
        confirmBirthDateTextView.setText("Место рождения: " + birthPlace);
        confirmUniversityTextView.setText("Университет : " + university);
        confirmCourseTextView.setText("Факультет: " + course);
        confirmSpecializationTextView.setText("Специальность: " + specialization);
        //endregion

        Log.d("Person", "Person: " + firstName + ", " + middleName + ", "
                + ", " + lastName + ", " + birthDate + ", " + birthDate + ", " + university + ", " + course + ", " + specialization);

        backToEducationActivityButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent= new Intent(getApplicationContext(), MainActivity3.class);
                startActivity(intent);
            }
        });

        confirmButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                final RequestPermissions requestPermission = new RequestPermissions();

                if(!requestPermission.permissionGranted) {
                    requestPermission.checkPermissions(context, activity);
                }

                Gson gson = new Gson();
                Person person = new Person(firstName, middleName, lastName, birthPlace,
                        birthDate, university, course, specialization);

                File file = new File(Environment.getExternalStorageDirectory(), "Lab_3.txt");
                FileWriter fw = null;

                try {
                    String jsstr = gson.toJson(person);
                    TextView outJson = findViewById(R.id.outJson);
                    outJson.clearComposingText();
                    outJson.setText(jsstr);
                    fw = new FileWriter(file, true);
                    BufferedWriter bw = new BufferedWriter(fw);
                    bw.write(jsstr);

                    bw.close();
                    fw.close();

                    Toast.makeText(getApplicationContext(), "Registration comleted", Toast.LENGTH_LONG).show();
                }
                catch (IOException e) {
                    e.printStackTrace();
                }
            }
        });
    }
}