package by.iaa.myapplication;

import java.io.Serializable;
import java.util.Calendar;

public class Person implements Serializable {
    String name;
    Calendar birthDate;
    String university;

    private String phone;
    private String email;
    private String link;


    public Person(String name, Calendar birthDate, String university, String phone, String email, String link) {
        this.name = name;
        this.birthDate = birthDate;
        this.university = university;
        this.phone = phone;
        this.email = email;
        this.link = link;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getLink() {
        return link;
    }

    public void setLink(String link) {
        this.link = link;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getUniversity() {
        return university;
    }

    public void setUniversity(String university) {
        this.university = university;
    }

    public Calendar getDate() {
        return birthDate;
    }

    public void setDate(Calendar date) {
        this.birthDate = date;
    }



    public String toString() {
        String str = getName();
        str += "\n" + getStringDate();
        str += "\n" + getUniversity();
        return str;
    }

    public String getStringDate() {
        int day = birthDate.get(Calendar.DATE);
        int month = birthDate.get(Calendar.MONTH) + 1;
        int year = birthDate.get(Calendar.YEAR);
        return (day < 10 ? "0" + day : day) + "." +
                (month < 10 ? "0" + month : month) + "." +
                year;
    }

    @Override
    public boolean equals(Object o) {
        if (o == null || o.getClass() != getClass())
            return false;

        Person c = (Person) o;
        if (name.equals(c.name) && university.equals(c.university))
            return true;

        return false;
    }
}
