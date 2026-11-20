using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Ouroboros.Common
{
	// Token: 0x02000010 RID: 16
	public class EnumHashSetTypeConverter<T> : TypeConverter where T : struct
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002C04 File Offset: 0x00000E04
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002C28 File Offset: 0x00000E28
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002C4C File Offset: 0x00000E4C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string))
			{
				string text = string.Empty;
				HashSet<T> hashSet = value as HashSet<T>;
				if (hashSet != null)
				{
					foreach (T t in hashSet)
					{
						if (text != string.Empty)
						{
							text += ",";
						}
						text += t.ToString();
					}
				}
				return text;
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002D00 File Offset: 0x00000F00
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null && context != null && context.PropertyDescriptor != null && context.PropertyDescriptor.PropertyType != null && value.GetType() == typeof(string) && value is string)
			{
				HashSet<T> hashSet = new HashSet<T>();
				string text = value as string;
				if (!string.IsNullOrEmpty(text))
				{
					string[] array = text.Split(new string[]
					{
						","
					}, StringSplitOptions.RemoveEmptyEntries);
					for (int i = 0; i < array.Length; i++)
					{
						T t;
						if (Enum.TryParse<T>(array[i], out t))
						{
							hashSet.Add(t);
						}
					}
				}
				return hashSet;
			}
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return TypeDescriptor.GetProperties(value.GetType());
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
