package by.iaa.lab12.models

data class Todos (
    override var id: Int,
    val userId: Int,
    val title: String,
    val completed: String
) : GenericEntity {
    override fun toString(): String {
        return "${this.userId} - ${this.title} - ${this.completed} !!!"
    }
}