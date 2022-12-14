package by.iaa.a2lab;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.material.slider.RangeSlider;

public class MainActivity extends AppCompatActivity implements AdapterView.OnItemSelectedListener, View.OnClickListener {

    private EditText LoanAmount;
    private Button ResultButton;
    private TextView ResultText;
    private Spinner LoanType;
    private Integer SelectedLoanTypeId;
    private RadioGroup RadioGroup;
    private RadioButton RadioButton;
    private Integer RadioId;
    private CheckBox CheckBox;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        LoanAmount = findViewById(R.id.loanAmount);
        ResultButton = findViewById(R.id.resultButton);
        ResultText = findViewById(R.id.resultText);
        LoanType = findViewById(R.id.loanType);
        RadioGroup = findViewById(R.id.radioGroup);
        RadioId = RadioGroup.getCheckedRadioButtonId();
        RadioButton = findViewById(RadioId);
        CheckBox = findViewById(R.id.checkbox);

        ArrayAdapter<CharSequence> adapter = ArrayAdapter.createFromResource(this, R.array.loanTypes, android.R.layout.simple_spinner_item);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        LoanType.setAdapter(adapter);



        LoanType.setOnItemSelectedListener(this);

        ResultButton.setOnClickListener(this);

    }

    @SuppressLint("ResourceAsColor")
    @Override
    public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
        SelectedLoanTypeId = i;
    }

    @Override
    public void onNothingSelected(AdapterView<?> adapterView) {

    }

    @Override
    public void onClick(View view) {
        try {
            Double amount = Double.valueOf(LoanAmount.getText().toString());

            Double percent = (SelectedLoanTypeId == 0) ? 0.20 : 0.25;
            percent -=  CheckBox.isChecked()? 0.05 : 0;

            int months = Integer.valueOf(RadioButton.getText().toString());

            Double finalPrice = (amount + (amount*percent)*(months/12))/months ;

            ResultText.setText(String.format("%.2f",finalPrice) + " руб/месяц");
        }
        catch (NumberFormatException e){
            Toast.makeText(MainActivity.this, R.string.CantConvertAmountError, Toast.LENGTH_SHORT).show();
        }
    }

    public  void checkButton (View v){
        RadioId = RadioGroup.getCheckedRadioButtonId();
        RadioButton = findViewById(RadioId);
    }
}