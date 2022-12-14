package by.iaa.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import by.iaa.myapplication.helpers.CustomTextWatcher;

public class MainActivity extends AppCompatActivity {
    Button button;
    EditText firstNameEditText, middleNameEditText, lastNameEditText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        firstNameEditText = findViewById(R.id.firstNameEditText);
        middleNameEditText = findViewById(R.id.middleNameEditText);
        lastNameEditText = findViewById(R.id.lastNameEditText);

        button = findViewById(R.id.button);
        button.setEnabled(false);
        button.getBackground().setAlpha(128);

        EditText[] editTexts = {firstNameEditText, middleNameEditText, lastNameEditText};
        CustomTextWatcher textWatcher = new CustomTextWatcher(editTexts, button);
        for (EditText editText : editTexts) {
            editText.addTextChangedListener(textWatcher);
        }

        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent= new Intent(getApplicationContext(), MainActivity2.class);

                Bundle bundle = new Bundle();
                bundle.putString("firstName", firstNameEditText.getText().toString());
                bundle.putString("middleName", middleNameEditText.getText().toString());
                bundle.putString("lastName", lastNameEditText.getText().toString());
                intent.putExtra("person", bundle);

                startActivity(intent);
            }
        });
    }
}