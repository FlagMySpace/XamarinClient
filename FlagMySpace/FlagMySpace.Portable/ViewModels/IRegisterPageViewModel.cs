﻿using XLabs.Forms.Mvvm;

namespace FlagMySpace.Portable.ViewModels
{
    public interface IRegisterPageViewModel : IViewModel
    {
        string Title { get; set; }
        string TextUsername { get; set; }
        string TextPassword { get; set; }
        string PlaceholderUsername { get; set; }
        string PlaceholderPassword { get; set; }
        string PlaceholderConfirmPassword { get; set; }
        string PlaceholderEmail { get; set; }
        string TextRegister { get; set; }
    }
}