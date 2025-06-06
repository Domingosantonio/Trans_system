using Microsoft.Extensions.DependencyInjection;
using Trans_system.Application.Features.Locations.Commands;
using Trans_system.Application.Features.Locations.Commands.Interfaces;
using Trans_system.Application.Features.Locations.Queries;
using Trans_system.Application.Features.Locations.Queries.Interfaces;
using Trans_system.Application.Features.Passengers.Commands;
using Trans_system.Application.Features.Passengers.Commands.Interfaces;
using Trans_system.Application.Features.Passengers.Queries;
using Trans_system.Application.Features.Passengers.Queries.Interfaces;
using Trans_system.Application.Features.Payments.Commands;
using Trans_system.Application.Features.Payments.Commands.Interfaces;
using Trans_system.Application.Features.Payments.Queries;
using Trans_system.Application.Features.Payments.Queries.Interfaces;
using Trans_system.Application.Features.Reservations.Commands;
using Trans_system.Application.Features.Reservations.Commands.Interfaces;
using Trans_system.Application.Features.Reservations.Queries;
using Trans_system.Application.Features.Reservations.Queries.Interfaces;
using Trans_system.Application.Features.Routes.Commands;
using Trans_system.Application.Features.Routes.Commands.Interfaces;
using Trans_system.Application.Features.Routes.Queries;
using Trans_system.Application.Features.Routes.Queries.Interfaces;
using Trans_system.Application.Features.Trips.Commands;
using Trans_system.Application.Features.Trips.Commands.Interfaces;
using Trans_system.Application.Features.Trips.Queries;
using Trans_system.Application.Features.Trips.Queries.Interfaces;
using Trans_system.Application.Features.Users.Commands;
using Trans_system.Application.Features.Users.Commands.Interfaces;
using Trans_system.Application.Features.Users.Queries;
using Trans_system.Application.Features.Users.Queries.Interfaces;
using Trans_system.Application.Features.Vehicles.Commands;
using Trans_system.Application.Features.Vehicles.Commands.Interfaces;
using Trans_system.Application.Features.Vehicles.Queries;
using Trans_system.Application.Features.Vehicles.Queries.Interfaces;


namespace Trans_system.Application;
public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection service)
    {
        #region Commands
        #region Register
        service.AddScoped<IRegisterLocationCommand, RegisterLocationCommand>();
        service.AddScoped<IRegisterPassengerCommand, RegisterPassengerCommand>();
        service.AddScoped<IRegisterPaymentCommand, RegisterPaymentCommand>();
        service.AddScoped<IRegisterReservationCommand, RegisterReservationCommand>();
        service.AddScoped<IRegisterRouteCommand, RegisterRouteCommand>();
        service.AddScoped<IRegisterTripCommand, RegisterTripCommand>();
        service.AddScoped<IRegisterUserCommand, RegisterUserCommand>();
        service.AddScoped<IRegisterVehicleCommand, RegisterVehicleCommand>();
        #endregion

        #region Update
        service.AddScoped<IUpdateLocationCommand, UpdateLocationCommand>();
        service.AddScoped<IUpdatePassengerCommand, UpdatePassengerCommand>();
        service.AddScoped<IUpdateReservationCommand, UpdateReservationCommand>();
        service.AddScoped<IUpdateRouteCommand, UpdateRouteCommand>();
        service.AddScoped<IUpdateTripCommand, UpdateTripCommand>();
        service.AddScoped<IUpdateUserCommand, UpdateUserCommand>();
        service.AddScoped<IUpdateVehicleCommand, UpdateVehicleCommand>();
        #endregion

        #region Delete
        service.AddScoped<IDeleteLocationCommand, DeleteLocationCommand>();
        service.AddScoped<IDeletePassengerCommand, DeletePassengerCommand>();
        service.AddScoped<IDeleteRouteCommand, DeleteRouteCommand>();
        service.AddScoped<IDeleteTripCommand, DeleteTripCommand>();
        service.AddScoped<IDeleteUserCommand, DeleteUserCommand>();
        service.AddScoped<IDeleteVehicleCommand, DeleteVehicleCommand>();
        #endregion

        #region Cancel
        service.AddScoped<ICancelPaymentCommand, CancelPaymentCommand>();
        service.AddScoped<ICancelReservationCommand, CancelReservationCommand>();
        service.AddScoped<ICancelTripCommand, CancelTripCommand>();
        #endregion

        #region Refund
        service.AddScoped<IRefundPaymentCommand, RefundPaymentCommand>();
        #endregion

        #region Close
        service.AddScoped<ICloseTripCommand, CloseTripCommand>();
        #endregion

        #region Replace
        service.AddScoped<IReplaceVehicleCommand, ReplaceVehicleCommand>();
        #endregion
        #endregion End Commands
       
        #region Queries
        #region GetAll
        service.AddScoped<IGetAllLocationsQuery, GetAllLocationsQuery>();
        service.AddScoped<IGetAllPassengersQuery, GetAllPassengersQuery>();
        service.AddScoped<IGetAllPaymentsQuery, GetAllPaymentsQuery>();
        service.AddScoped<IGetAllReservationsQuery, GetAllReservationsQuery>();
        service.AddScoped<IGetAllRoutesQuery, GetAllRoutesQuery>();
        service.AddScoped<IGetAllTripsQuery, GetAllTripsQuery>();
        service.AddScoped<IGetAllUsersQuery, GetAllUsersQuery>();
        service.AddScoped<IGetAllVehiclesQuery, GetAllVehiclesQuery>();
        #endregion

        #region GetTripHistoryByVehicle
        service.AddScoped<IGetTripHistoryByVehicleQuery, GetTripHistoryByVehicleQuery>();
        #endregion
        #endregion
    }
}
