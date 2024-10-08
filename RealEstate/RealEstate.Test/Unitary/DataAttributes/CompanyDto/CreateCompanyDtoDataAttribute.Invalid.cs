#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

using System.Reflection;
using RealEstate.Shared.Dtos;
using Xunit.Sdk;

namespace RealEstate.Test.Unitary.DataAttributes.CompanyDto;

public class CreateCompanyDtoDataAttribute_Invalid : DataAttribute
{
    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        yield return new object[] { CompanyWithoutName() };
        yield return new object[] { CompanyWithoutEmail() };
        yield return new object[] { CompanyWithWrongEmailPattern() };
        yield return new object[] { CompanyWithoutPhone() };
        yield return new object[] { CompanyWithWrongPhoneLength() };
        yield return new object[] { CompanyPhoneWithLetters() };
        yield return new object[] { CompanyWithoutCnpj() };
        yield return new object[] { CompanyWithWrongCnpjLength() };
        yield return new object[] { CompanyCnpjWithLetters() };
    }

    public static CreateCompanyDto CompanyWithoutName()
    {
        CreateCompanyDto dto = CreateCompanyDtoDataAttribute_Valid.Company1();
        dto.Name = null;
        return dto;
    }

    public static CreateCompanyDto CompanyWithoutEmail()
    {
        CreateCompanyDto dto = CreateCompanyDtoDataAttribute_Valid.Company1();
        dto.Email = null;
        return dto;
    }

    public static CreateCompanyDto CompanyWithWrongEmailPattern()
    {
        CreateCompanyDto dto = CreateCompanyDtoDataAttribute_Valid.Company1();
        dto.Email = "email@.com.dev";
        return dto;
    }

    public static CreateCompanyDto CompanyWithoutPhone()
    {
        CreateCompanyDto dto = CreateCompanyDtoDataAttribute_Valid.Company1();
        dto.Phone = null;
        return dto;
    }

    public static CreateCompanyDto CompanyWithWrongPhoneLength()
    {
        CreateCompanyDto dto = CreateCompanyDtoDataAttribute_Valid.Company1();
        dto.Phone = "123";
        return dto;
    }

    public static CreateCompanyDto CompanyPhoneWithLetters()
    {
        CreateCompanyDto dto = CreateCompanyDtoDataAttribute_Valid.Company1();
        dto.Phone = "32165487ss";
        return dto;
    }

    public static CreateCompanyDto CompanyWithoutCnpj()
    {
        CreateCompanyDto dto = CreateCompanyDtoDataAttribute_Valid.Company1();
        dto.Cnpj = null;
        return dto;
    }

    public static CreateCompanyDto CompanyWithWrongCnpjLength()
    {
        CreateCompanyDto dto = CreateCompanyDtoDataAttribute_Valid.Company1();
        dto.Cnpj = "123";
        return dto;
    }

    public static CreateCompanyDto CompanyCnpjWithLetters()
    {
        CreateCompanyDto dto = CreateCompanyDtoDataAttribute_Valid.Company1();
        dto.Cnpj = "123ad112dd";
        return dto;
    }
}
