
using System.Net;

namespace VetClinic.Shared.Exceptions;
public sealed record ExceptionResponse(object Response, HttpStatusCode StatusCode);
