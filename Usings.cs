

#if ANDROID

global using Android.App;
global using Android.Content.PM;
global using Android.Runtime;

#elif IOS

global using Foundation;
global using UIKit;
global using CoreGraphics;
global using UserNotifications;  
global using Microsoft.Maui.LifecycleEvents;

#endif

global using MauiPointF = Microsoft.Maui.Graphics.PointF;
global using System.ComponentModel.DataAnnotations;
global using Glitchy_UI.Helpers;
global using System.Globalization;
global using Glitchy_UI.ViewModels;
global using CommunityToolkit.Mvvm.ComponentModel;
global using Glitchy_UI.Models.Converters;
global using CommunityToolkit.Mvvm.Input;
global using Microsoft.Extensions.Logging;
global using System.Diagnostics;
global using Glitchy_UI.DependencyInjection;
global using System.Diagnostics.CodeAnalysis;
global using Application = Microsoft.Maui.Controls.Application;
global using System.Runtime.Serialization;
global using Glitchy_UI.CustomException;
global using Glitchy_UI.Views;
global using Glitchy_UI.Models;
global using CommunityToolkit.Mvvm.Messaging;
global using JsonSerializer = System.Text.Json.JsonSerializer;
global using Glitchy_UI.Types;
global using System.Reflection;
global using System.Collections.ObjectModel;
global using System.ComponentModel;
global using Glitchy_UI.Groups;
global using Glitchy_UI.Models.ViewModels;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using Glitchy_UI.JsonConverters;
global using System.Net;
global using System.Text.RegularExpressions;
global using Glitchy_UI.ViewModels.TabViewModels;
