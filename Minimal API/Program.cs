using Microsoft.OpenApi.Models;
using Microsoft.VisualBasic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = " Minimal API",
        Description = "Minimal API",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
   {
       options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
       options.RoutePrefix = string.Empty;
   });
}

/// User API

Userfunctionimplementation implementuserfunction = new Userfunctionimplementation();
List<Userregisterclass> userlist = new List<Userregisterclass>() { new Userregisterclass { Datejoined = DateTime.Now, EmailAddress = "vv@gmail.com", FirstName = "Tolu", LastName = "Vince", isPaidUser = false, Language = "Espanol", Picture = FileAccess.Read, PhoneNumber = "08055994433", Password = "12344", Pin = 12345, Userid = 1 } };



// Register user

app.MapPost("v1/user/registeruser", (Userregisterclass registernewuser) =>
{
    var isregistered = implementuserfunction.Registeruser(registernewuser, userlist);
    if (isregistered)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status400BadRequest;
    }
});

// Get all users
app.MapGet("v1/user/getallusers", () =>
{
    return implementuserfunction.Getallusers(userlist);
});

// Get one user
app.MapGet("v1/user/getonuser", (int userid) =>
{
    return implementuserfunction.Getoneuser(userid, userlist);
});

// Update user
app.MapPut("v1/user/updateuser", (Userregisterclass updatereg) =>
{
    var updatemyuser = implementuserfunction.Updateuser(updatereg, userlist);
    if (updatemyuser)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status304NotModified;
    }
});

// Delete user
app.MapDelete("v1/user/deleteuser", (int userid) =>
{
    var deletemyuser = implementuserfunction.Deleteuser(userid, userlist);
    if (deletemyuser)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status304NotModified;
    }
});


/// Store API

StoreFunctionImplementation implementstorefunction = new StoreFunctionImplementation();
List<RegisterStoreClass> storelist = new List<RegisterStoreClass>() { new RegisterStoreClass { StoreName = "Vince store", StoreId = 1, MakerName = "Vincedacode", ItemName = "Vince wears", Itemtype = "Cloth", Color = ["red", "green", "pink"], Price = 133000, Categoryid = 23, IsAvailable = true, Model = "Nike", ModelNumber = 12332, QuantityLeft = 345, DateCreated = DateTime.Now } };

// Register store
app.MapPost("v1/store/registerstore", (RegisterStoreClass storereg) =>
{
    var register = implementstorefunction.RegisterStore(storereg, storelist);
    if (register)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status400BadRequest;
    }
});

// Get all stores
app.MapGet("v1/store/getallstores", () =>
{
    return implementstorefunction.Getallstores(storelist);
});

// Get one store
app.MapGet("v1/store/getonestore", (int storeid) =>
{
    return implementstorefunction.Getonestore(storeid, storelist);
});

// Update store
app.MapPut("v1/store/updatestore", (RegisterStoreClass updatestore) =>
{
    var updatemystore = implementstorefunction.Updatestore(updatestore, storelist);
    if (updatemystore)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status304NotModified;
    }
});

// Delete store
app.MapDelete("v1/store/deletestore", (int storeid) =>
{
    var deletestore = implementstorefunction.Deletestore(storeid, storelist);
    if (deletestore)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status304NotModified;
    }
});


/// Group API

Groupfunctionimplementation implementgroupfunction = new Groupfunctionimplementation();
List<RegisterGroupClass> grouplist = new List<RegisterGroupClass>() { new RegisterGroupClass { AdminList = ["Josh", "Raph", "Peter"], GroupName = "Ravers GC", GroupOwner = "Vincedacode", GroupId = 123, GroupPicture = FileOptions.RandomAccess, MembersId = [1, 2, 3, 4, 5], DateAndTimeCreated = DateTime.Now } };

// Create Group
app.MapPost("v1/group/creategroup", (RegisterGroupClass groupreg) =>
{
    var creategroup = implementgroupfunction.RegisterGroup(groupreg, grouplist);
    if (creategroup)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status304NotModified;
    }
});

// Get all groups
app.MapGet("v1/group/getallgroups", () =>
{
    return implementgroupfunction.Getallgroups(grouplist);
});

// Get one group
app.MapGet("v1/group/getonegroup", (int groupid) =>
{
    return implementgroupfunction.Getonegroup(groupid, grouplist);
});

// Update Group
app.MapPut("v1/group/updategroup", (RegisterGroupClass updatemygroup) =>
{
    var update = implementgroupfunction.Updategroup(updatemygroup, grouplist);
    if (update)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status304NotModified;
    }
});

// Delete Group
app.MapDelete("v1/group/deletegroup", (int groupid) =>
{
    var deletegroup = implementgroupfunction.DeleteGroup(groupid, grouplist);
    if (deletegroup)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status304NotModified;
    }
});


/// Chat API
Random generateid = new Random();
int chatid = generateid.Next(1, 100);
int sendid = generateid.Next(1, 100);
int receiveid = generateid.Next(1, 100);

ChatFunctionImplementation implementchatfunction = new ChatFunctionImplementation();
List<RegisterChatClass> chatlist = new List<RegisterChatClass>() { new RegisterChatClass { ChatId = chatid, UserName = "Vincedacode", Receiver_Name = "treasure", SenderId = sendid, ReceiverId = receiveid, Message = "Hey, how are you doing", DateandTIme = DateTime.Now } };

//New Chat
app.MapPost("v1/chat/newchat", (RegisterChatClass newchat) =>
{
    var createchat = implementchatfunction.Newchat(newchat, chatlist);
    if (createchat)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status304NotModified;
    }
});


// Get all chats
app.MapGet("v1/chat/getallchats", () =>
{
    return implementchatfunction.Getallchats(chatlist);
});

// Getonechat
app.MapGet("v1/chat/getonechat", (int Chatid) =>
{
    return implementchatfunction.Getonechat(Chatid, chatlist);
});

// Edit Chat
app.MapPut("v1/chat/editchat", (RegisterChatClass editchat) =>
{
    var edit = implementchatfunction.Editchat(editchat, chatlist);
    if (edit)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status304NotModified;
    }
});

// Delete chat
app.MapDelete("v1/chat/deletechat", (int chatid) =>
{
    var delchat = implementchatfunction.Deletechat(chatid, chatlist);
    if (delchat)
    {
        return StatusCodes.Status200OK;
    }
    else
    {
        return StatusCodes.Status304NotModified;
    }
});



app.Run();
