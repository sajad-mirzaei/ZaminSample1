﻿namespace MiniBlog.Core.Contracts.People.Queries.GetPersonById;
public class PersonByIdDto
{
    public long Id { get; set; }
    public Guid BusinessId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? CreatedByUserId { get; set; }
    public string? CreatedByUserName { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public string? ModifiedByUserId { get; set; }
    public string? ModifiedByUserName { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
}