package by.iaa.myapplication.Adapters;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;

import java.util.List;

import by.iaa.myapplication.Models.Image;
import by.iaa.myapplication.Models.Item;
import by.iaa.myapplication.R;

public class ItemAdapter extends ArrayAdapter {

    private LayoutInflater inflater;
    private int layout;
    private List<Item> items;

    public ItemAdapter(@NonNull Context context, int resource, List<Item> events) {
        super(context, resource, events);
        this.items = events;
        this.layout = resource;
        this.inflater = LayoutInflater.from(context);
    }

    public View getView(int position, View convertView, ViewGroup parent) {
        View view = inflater.inflate(this.layout, parent, false);

        ImageView imageView = view.findViewById(R.id.imageView);
        TextView nameView = view.findViewById(R.id.name);
        TextView date = view.findViewById(R.id.date);

        Item event = items.get(position);


        Image.getInstance().loadImageFromStorage(imageView, event.pathImages);
        nameView.setText(event.name);
        date.setText(event.getStringDateForListView());

        return view;
    }
}
