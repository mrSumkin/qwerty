using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

// Token: 0x020000BA RID: 186
public class bf7 : TypeConverter
{
	// Token: 0x06000430 RID: 1072 RVA: 0x00013BB8 File Offset: 0x00011DB8
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00013BDC File Offset: 0x00011DDC
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00013C00 File Offset: 0x00011E00
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (!(destinationType == typeof(string)))
		{
			return base.ConvertTo(context, culture, value, destinationType);
		}
		if (value != null)
		{
			return value.ToString();
		}
		return null;
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00013C34 File Offset: 0x00011E34
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value != null && context != null && context.PropertyDescriptor != null && context.PropertyDescriptor.PropertyType != null)
		{
			Type type = value.GetType();
			Type propertyType = context.PropertyDescriptor.PropertyType;
			MethodInfo method = propertyType.GetMethod("Parse", BindingFlags.Static | BindingFlags.Public, null, new Type[]
			{
				type
			}, null);
			if (method != null && method.ReturnType == propertyType)
			{
				return method.Invoke(null, new object[]
				{
					value
				});
			}
		}
		return null;
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00013CCC File Offset: 0x00011ECC
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		return TypeDescriptor.GetProperties(value.GetType());
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00013CDC File Offset: 0x00011EDC
	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return true;
	}
}
