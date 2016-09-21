using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPerFerryContract.Interface
{
    interface ContractV2
    {

        /// <summary>
        /// Fetches a list of all departures on a given route, in a given time interval.
        /// </summary>
        /// <param name="routeDTO">The ID on the route that the user wishes to travel with</param>
        /// <param name="startDate">The startpoint date for the interval the user wants to search in</param>
        /// <param name="endDate">The endpoint date for the interval the user wants to search in</param>
        /// <returns>Returns a List of departures</returns>
        List<DepartureDTO> GetDepartures(long routeId, DateTime startDate, DateTime endDate);

        /// <summary>
        /// Attempts to make a reservation on the departure that a user wishes to travel with.
        /// </summary>
        /// <param name="departureId">The ID of the departure</param>
        /// <param name="userName">The full name of the user making the reservation</param>
        /// <param name="vehicleDTO">VehicleDTO of the vehicle the user wants to travel in. This field will be null if the passenger is walking</param>
        /// <param name="amountPassengers">The amount of passengers that the reservation is made for</param>
        /// <returns></returns>
        ReservationDTO BookReservation(long departureId, string userName, VehicleDTO vehicleDTO, int amountPassengers);

        /// <summary>
        /// Fetches a single reservation on a given ID
        /// </summary>
        /// <param name="reservationId">The id of the reservation that the user wishes to browse</param>
        /// <returns>Returns a single ReservationDTO</returns>
        ReservationDTO GetReservationById(long reservationId);

        /// <summary>
        /// Fetches all the routes
        /// </summary>
        /// <returns>List of RouteDTO's</returns>
        List<RouteDTO> GetRoutes();

        /// <summary>
        /// Allows an admin to create new departures.
        /// </summary>
        /// <param name="departureDTO">The departureDTO created by the front-end, without an ID</param>
        /// <returns>The created DepartureDTO, including the ID</returns>
        DepartureDTO MakeDeparture(DepartureDTO departureDTO);

        /// <summary>
        /// Allows an admin to edit an existing departure.
        /// </summary>
        /// <param name="departureDTO">The departureDTO with edited values, the depatureId MUST remain the same</param>
        /// <returns>Returns the edited DepartureDTO</returns>
        DepartureDTO ChangeDeparture(DepartureDTO departureDTO);


    }
}
