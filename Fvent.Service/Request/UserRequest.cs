﻿using Fvent.BO.Enums;

namespace Fvent.Service.Request;

public record AuthReq(string Email, string Password, string? FcmToken);

public record RefreshTokenReq(string Token);

public record GetListUsersReq(string? Username, string? Email, string? RoleName, string? Verified, string? OrderBy,
                              bool IsDescending = false, int PageNumber = 1, int PageSize = 9);
public record GetRegisteredUsersReq(string? SearchKeyword, int PageNumber = 1, int PageSize = 9);

public record CreateUserReq(string Username, string Email, string Password, string StudentId, 
                            string PhoneNumber, UserRole Role);

public record CreateModeratReq(string Username, string Email, string Password);

public record UpdateUserReq(string Username, string AvatarUrl, string PhoneNumber, string StudentId);

public record ForgotPasswordReq(string Email);
public record ChangePasswordRequest(string OldPassword, string NewPassword);
public record ApproveUserRequest(string ProcessNote);
public record AddCardIdRequest(string CardUrl);
