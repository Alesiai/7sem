package by.iaa.lab12.retrofit

import by.iaa.lab12.models.Todos
import by.iaa.lab12.models.Superhero
import by.iaa.lab12.models.User
import retrofit2.Call
import retrofit2.http.GET

interface Services {
    @GET("/demos/marvel")
    fun getSuperheroes(): Call<MutableList<Superhero>>

    @GET("/todos")
    fun getPosts(): Call<MutableList<Todos>>

    @GET("/users")
    fun getUsers(): Call<MutableList<User>>
}