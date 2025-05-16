namespace MeDesenvolveIA.API.Endpoints;

public static class PDIEndPoints
{
	public static void MapPDIEndpoints(this IEndpointRouteBuilder app)
	{
		var group = app.MapGroup("api/v1/pdi")
						.WithTags("pdi");

	}
}
