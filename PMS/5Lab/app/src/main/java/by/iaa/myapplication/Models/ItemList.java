package by.iaa.myapplication.Models;

import android.content.Context;

import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.List;

public class ItemList {
    private final String fileName = "items";
    public List<Item> items;
    JsonHelper<Item> jsonHelper;
    static Context context;

    public ItemList(Context context) {
        this.context = context;
        jsonHelper = new JsonHelper<>();
        Type typeClass = new TypeToken<List<Item>>() {
        }.getType();
        items = new ArrayList<>(jsonHelper.importFromJSON(this.context, fileName, typeClass));
        if (items == null)
            items = new ArrayList<>();

    }

    public void AddItem(Item item) {
        items.add(item);
        Type typeClass = new TypeToken<List<Item>>() {
        }.getType();
        jsonHelper.exportToJSON(this.context, items, fileName, typeClass);
    }
    public void RemoveItem(Item item) {
        items.remove(item);
        Type typeClass = new TypeToken<List<Item>>() {
        }.getType();
        jsonHelper.exportToJSON(this.context, items, fileName, typeClass);
    }
}
