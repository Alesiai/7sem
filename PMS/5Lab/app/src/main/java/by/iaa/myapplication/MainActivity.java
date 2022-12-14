package by.iaa.myapplication;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Dialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.ListView;

import java.util.Collections;
import java.util.Comparator;
import java.util.EventListener;

import by.iaa.myapplication.Adapters.ItemAdapter;
import by.iaa.myapplication.Models.Item;
import by.iaa.myapplication.Models.ItemList;

public class MainActivity extends AppCompatActivity {

    ListView items;
    ItemList itemsList;
    final int DIALOG_DELETE = 1;
    Item selectedItem;
    ItemAdapter adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        items = findViewById(R.id.items);
        registerForContextMenu(items);

        itemsList = new ItemList(this);
        Intent intent = new Intent(this, EditItem.class);
        adapter = new ItemAdapter(this, R.layout.item_list, itemsList.items);
        items.setAdapter(adapter);

        AdapterView.OnItemClickListener itemClickListener = new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                Item item = (Item) adapterView.getItemAtPosition(i);
                intent.putExtra("item", item);
                startActivity(intent);
            }
        };
        items.setOnItemClickListener(itemClickListener);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.main_menu, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.add:
                Intent intent = new Intent(this, AddItem.class);
                startActivity(intent);
                return true;
            case R.id.asc:
            {
                Collections.sort(itemsList.items, new Comparator<Item>() {
                    @Override
                    public int compare(Item item1, Item t1) {
                        return item1.calendar.compareTo(t1.calendar);
                    }
                });
                adapter.notifyDataSetChanged();
            };
                return true;
            case R.id.desc: {
                Collections.sort(itemsList.items, new Comparator<Item>() {
                    @Override
                    public int compare(Item item1, Item t1) {
                        return t1.calendar.compareTo(item1.calendar);
                    }
                });
                adapter.notifyDataSetChanged();
            }
            case R.id.phone:{
                    Intent intentph = new Intent(Intent.ACTION_DIAL,
                            Uri.parse("tel:" + "+375297347624"));
                    if (intentph.resolveActivity(getPackageManager()) != null) {
                        startActivity(intentph);
                    }
                    startActivity(intentph);
            }
                return true;
            default:
                return true;
        }
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v,
                                    ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        getMenuInflater().inflate(R.menu.edit_menu, menu);
    }

    @Override
    public boolean onContextItemSelected(MenuItem item) {
        AdapterView.AdapterContextMenuInfo info = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();
        selectedItem = (Item) items.getItemAtPosition(info.position);
        switch (item.getItemId()) {
            case R.id.open:
                InfoEvent();
                return true;
            case R.id.edit:
                ChangeEvent();
                return true;
            case R.id.delete:
                showDialog(DIALOG_DELETE);
                return true;
            default:
                return super.onContextItemSelected(item);
        }
    }

    public void ChangeEvent() {
        Intent intent = new Intent(this, EditItem.class);
        intent.putExtra("item", selectedItem);
        startActivity(intent);
    }

    public void InfoEvent() {
        Intent intent = new Intent(this, ViewItem.class);
        intent.putExtra("item", selectedItem);
        startActivity(intent);
    }

    protected Dialog onCreateDialog(int id) {
        AlertDialog.Builder al = new AlertDialog.Builder(this);
        al.setTitle("Удаление");
        al.setMessage("Вы действительно хотите удалить активность?");
        al.setPositiveButton("Да", clickListener);
        al.setNegativeButton("Нет", clickListener);
        return al.create();
    }

    DialogInterface.OnClickListener clickListener = new DialogInterface.OnClickListener() {
        @Override
        public void onClick(DialogInterface dialogInterface, int i) {
            switch (i) {
                case DialogInterface.BUTTON_POSITIVE:
                    itemsList.RemoveItem(selectedItem);
                    adapter.notifyDataSetChanged();
                    return;
                case DialogInterface.BUTTON_NEGATIVE:
                    return;

            }
        }
    };

}