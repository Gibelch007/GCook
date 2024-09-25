using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using GCook.Data;
using GCook.ViewModels;
using Microsoft.EntityFrameworkCore;
using GCook.Helpers;
using GCook.Models;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Encodings.Web;
using Gcook.Services;


namespace GCook.Services;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _contexto;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IUserStore<IdentityUser> _userStore;
    private readonly IUserEmailStore<IdentityUser> _emailStore;
    private readonly IWebHostEnvironment _hostEnvironment;
    private readonly IEmailSender _emailSender;
    private readonly ILogger<UsuarioService> _logger;

    public UsuarioService(
        AppDbContext contexto,
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager,
        IHttpContextAccessor httpContextAccessor,
        IUserStore<IdentityUser> userStore,
        IWebHostEnvironment hostEnvironment,
        IEmailSender emailSender,
        ILogger<UsuarioService> logger
    )
    {
        _contexto = contexto;
        _signInManager = signInManager;
        _userManager = userManager;
        _userStore = userStore;
        _emailStore = (IUserEmailStore<IdentityUser>)_userStore;
        _hostEnvironment = hostEnvironment;
        _emailSender = emailSender;
        _logger = logger;

    }

    public async Task<bool> ConfirmarEmail(string userId, string code)
    {
        var user = await _userManager.FindByEmailAsync(userId)
    }

}