package by.iaa.a14_15.data

import android.location.Location
import java.util.*

class Route(val id: String = UUID.randomUUID().toString(), var startLocation: Location?, var finishLocation: Location?)