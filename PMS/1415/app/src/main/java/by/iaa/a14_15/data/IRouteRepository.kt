package by.iaa.a14_15.data

interface IRouteRepository {
    fun saveRoute(route: Route)

    fun getRoutes(): ArrayList<Route>

    fun updateRoute(updatedRoute: Route)
}