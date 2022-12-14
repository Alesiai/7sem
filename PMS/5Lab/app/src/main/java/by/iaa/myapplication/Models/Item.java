package by.iaa.myapplication.Models;

import java.io.Serializable;
import java.util.Calendar;
import java.util.Objects;

public class Item implements Serializable {
    public String name;
    public String description;
    public Calendar calendar;
    public String pathImages;

    public Item(String name, String description, Calendar calendar, String pathImages) {
        this.name = name;
        this.description = description;
        this.calendar = calendar;
        this.pathImages = pathImages;
    }

    public Item(String name, String description, Calendar calendar) {
        this.name = name;
        this.description = description;
        this.calendar = calendar;
    }

    public String getNameImage() {
        return name + calendar.get(Calendar.YEAR) + calendar.get(Calendar.MONTH) + calendar.get(Calendar.DATE) +
                calendar.get(Calendar.HOUR) + calendar.get(Calendar.MINUTE);
    }

    public String getStringDateForListView() {
        return getStringDate() + "\n" + getStringTime();
    }

    public String getStringDate() {
        int month = calendar.get(Calendar.MONTH) + 1;
        int day = calendar.get(Calendar.DATE);
        return (day < 10 ? "0" + day : day) + "." +
                (month < 10 ? "0" + month : month) + "." +
                calendar.get(Calendar.YEAR);
    }

    public String getStringTime() {
        int hour = calendar.get(Calendar.HOUR);
        int minute = calendar.get(Calendar.MINUTE);
        return (hour < 10 ? "0" + hour : hour) + ":" +
                (minute < 10 ? "0" + minute : minute);
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Item item = (Item) o;
        return name.equals(item.name) && Objects.equals(description, item.description) &&
                Objects.equals(calendar, item.calendar) && pathImages.equals(item.pathImages);
    }

    @Override
    public int hashCode() {
        return Objects.hash(name, description, calendar, pathImages);
    }
}
