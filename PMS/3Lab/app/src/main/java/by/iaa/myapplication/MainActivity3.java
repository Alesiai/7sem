package by.iaa.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;

import by.iaa.myapplication.helpers.CustomTextWatcher;

public class MainActivity3 extends AppCompatActivity {
    Button backToBirthdayActivityButton;
    Button toVerificationActivityButton;
    EditText universityEditText, courseEditText, specializationEditText;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main3);
        universityEditText = findViewById(R.id.universityEditText);
        courseEditText = findViewById(R.id.fack);
        specializationEditText = findViewById(R.id.specializationEditText);
        toVerificationActivityButton = findViewById(R.id.toVerificationActivityButton);
        backToBirthdayActivityButton = findViewById(R.id.backToBirthdayActivityButton);
        toVerificationActivityButton.setEnabled(false);
        toVerificationActivityButton.getBackground().setAlpha(128);

        EditText[] editTexts = {universityEditText, courseEditText, specializationEditText};
        CustomTextWatcher textWatcher = new CustomTextWatcher(editTexts, toVerificationActivityButton);
        for (EditText editText : editTexts) {
            editText.addTextChangedListener(textWatcher);
        }

        toVerificationActivityButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent= new Intent(getApplicationContext(), MainActivity4.class);
                Bundle bundle = getIntent().getBundleExtra("person");

                bundle.putString("university", universityEditText.getText().toString());
                bundle.putString("fack", courseEditText.getText().toString());
                bundle.putString("specialization", specializationEditText.getText().toString());
                intent.putExtra("person", bundle);
                startActivity(intent);
            }
        });

        backToBirthdayActivityButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent= new Intent(getApplicationContext(), MainActivity2.class);
                startActivity(intent);
            }
        });
    }
}