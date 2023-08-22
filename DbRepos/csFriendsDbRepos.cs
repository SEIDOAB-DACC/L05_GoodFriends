using Configuration;
using Models;
using Models.DTO;
using DbModels;
using DbContext;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;

//DbRepos namespace is a layer to abstract the detailed plumming of
//retrieveing and modifying and data in the database using EFC.

//DbRepos implements database CRUD functionality using the DbContext
namespace DbRepos;

public class csFriendsDbRepos
{
    private ILogger<csFriendsDbRepos> _logger = null;

    #region used before csLoginService is implemented
    private string _dblogin = "sysadmin";
    //private string _dblogin = "gstusr";
    //private string _dblogin = "usr";
    //private string _dblogin = "supusr";
    #endregion


    #region only for layer verification
    private Guid _guid = Guid.NewGuid();
    private string _instanceHello = null;

    static public string Hello { get; } = $"Hello from namespace {nameof(DbRepos)}, class {nameof(csFriendsDbRepos)}";
    public string InstanceHello => _instanceHello;
    #endregion


    #region contructors
    public csFriendsDbRepos()
    {
        _instanceHello = $"Hello from class {this.GetType()} with instance Guid {_guid}.";
    }
    public csFriendsDbRepos(ILogger<csFriendsDbRepos> logger):this()
    {
        _logger = logger;
        _logger.LogInformation(_instanceHello);
    }
    #endregion


    #region Admin repo methods
    //implementation using View
    public async Task<gstusrInfoAllDto> InfoAsync()
        => throw new NotImplementedException();

    public async Task<adminInfoDbDto> SeedAsync(loginUserSessionDto usr, int nrOfItems)
        => throw new NotImplementedException();
  
    public async Task<adminInfoDbDto> RemoveSeedAsync(loginUserSessionDto usr, bool seeded)
        => throw new NotImplementedException();
    #endregion


    #region Friends repo methods
    public async Task<IFriend> ReadFriendAsync(loginUserSessionDto usr, Guid id, bool flat)
        => throw new NotImplementedException();

    public async Task<List<IFriend>> ReadFriendsAsync(loginUserSessionDto usr, bool seeded, bool flat, string filter, int pageNumber, int pageSize)
        => throw new NotImplementedException();

    public async Task<IFriend> DeleteFriendAsync(loginUserSessionDto usr, Guid id)
       => throw new NotImplementedException();

    public async Task<IFriend> UpdateFriendAsync(loginUserSessionDto usr, csFriendCUdto itemDto)
       => throw new NotImplementedException();

    public async Task<IFriend> CreateFriendAsync(loginUserSessionDto usr, csFriendCUdto itemDto)
       => throw new NotImplementedException();
    #endregion


    #region Addresses repo methods
    public async Task<IAddress> ReadAddressAsync(loginUserSessionDto usr, Guid id, bool flat)
       => throw new NotImplementedException();

    public async Task<List<IAddress>> ReadAddressesAsync(loginUserSessionDto usr, bool seeded, bool flat, string filter, int pageNumber, int pageSize)
       => throw new NotImplementedException();

    public async Task<IAddress> DeleteAddressAsync(loginUserSessionDto usr, Guid id)
       => throw new NotImplementedException();

    public async Task<IAddress> UpdateAddressAsync(loginUserSessionDto usr, csAddressCUdto itemDto)
       => throw new NotImplementedException();

    public async Task<IAddress> CreateAddressAsync(loginUserSessionDto usr, csAddressCUdto itemDto)
       => throw new NotImplementedException();
    #endregion


    #region Quotes repo methods
    public async Task<IQuote> ReadQuoteAsync(loginUserSessionDto usr, Guid id, bool flat)
       => throw new NotImplementedException();

    public async Task<List<IQuote>> ReadQuotesAsync(loginUserSessionDto usr, bool seeded, bool flat, string filter, int pageNumber, int pageSize)
       => throw new NotImplementedException();

    public async Task<IQuote> DeleteQuoteAsync(loginUserSessionDto usr, Guid id)
       => throw new NotImplementedException();

    public async Task<IQuote> UpdateQuoteAsync(loginUserSessionDto usr, csQuoteCUdto itemDto)
       => throw new NotImplementedException();

    public async Task<IQuote> CreateQuoteAsync(loginUserSessionDto usr, csQuoteCUdto itemDto)
       => throw new NotImplementedException();
    #endregion


    #region Pets repo methods
    public async Task<IPet> ReadPetAsync(loginUserSessionDto usr, Guid id, bool flat)
       => throw new NotImplementedException();

    public async Task<List<IPet>> ReadPetsAsync(loginUserSessionDto usr, bool seeded, bool flat, string filter, int pageNumber, int pageSize)
       => throw new NotImplementedException();

    public async Task<IPet> DeletePetAsync(loginUserSessionDto usr, Guid id)
       => throw new NotImplementedException();

    public async Task<IPet> UpdatePetAsync(loginUserSessionDto usr, csPetCUdto itemDto)
       => throw new NotImplementedException();

    public async Task<IPet> CreatePetAsync(loginUserSessionDto usr, csPetCUdto itemDto)
       => throw new NotImplementedException();
    #endregion
}
