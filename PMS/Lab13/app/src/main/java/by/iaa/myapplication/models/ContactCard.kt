package by.iaa.myapplication.models

import androidx.databinding.BaseObservable
import androidx.databinding.Bindable
import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import by.iaa.myapplication.BR

@Entity(tableName = "contact_card")
data class ContactCard (
    @PrimaryKey(autoGenerate = true)
    @ColumnInfo(name = "id")
    var Id: Int? = null,
    @ColumnInfo(name = "name")
    var Name: String = "",
    @ColumnInfo(name = "address")
    var Address: String = "",
    @ColumnInfo(name = "phone_number")
    var PhoneNumber: String = "",
    @ColumnInfo(name = "website")
    var Website: String = "",
    @ColumnInfo(name = "image")
    var Image: String = "",
)