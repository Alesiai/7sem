package by.iaa.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.os.Parcelable;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.List;

public class MainActivity extends AppCompatActivity {
    ListView persons;
    List<Person> personList;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Intent intent = new Intent(this, PersonInformationActivity.class);

        persons = findViewById(R.id.listView);

        personList = JsonHelper.importFromJSON(this);

        if (personList != null) {

            ArrayAdapter<Person> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, personList);
            persons.setAdapter(adapter);

            AdapterView.OnItemClickListener itemClickListener = new AdapterView.OnItemClickListener() {
                @Override
                public void onItemClick(AdapterView<?> parent, View view, int i, long l) {
                    Person person = (Person) parent.getItemAtPosition(i);
                    intent.putExtra("person", person);
                    startActivity(intent);
                }
            };
            persons.setOnItemClickListener(itemClickListener);
        }
    }

    public void add(View v) {
        Intent intent = new Intent(this, PersonActivity.class);
        startActivity(intent);
    }
}