using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B25 RID: 2853
[eiz("XPBLUPDHPZZ")]
[Serializable]
public sealed class ard : cze, ISerializable
{
	// Token: 0x060041D7 RID: 16855 RVA: 0x001972D8 File Offset: 0x001954D8
	private ard(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041D8 RID: 16856 RVA: 0x001972E4 File Offset: 0x001954E4
	public ard()
	{
	}

	// Token: 0x060041D9 RID: 16857 RVA: 0x001972EC File Offset: 0x001954EC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("interface_up_dh_console_currentEntry", new int?(0)).Value;
		int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("interface_up_dh_console_numberOfEntries", new int?(0)).Value;
		bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interface_up_dh_console_passedFirstSet", new bool?(false)).Value;
		bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interface_up_dh_console_passedSecondSet", new bool?(false)).Value;
		bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interface_up_dh_console_passedThirdSet", new bool?(false)).Value;
		string text = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("interface_up_dh_console_entryList");
		if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interface_up_dh_console_reset", new bool?(false)).Value)
		{
			serviceOrThrow.aqu().r()["interface_up_dh_console_currentEntry"] = 0;
			serviceOrThrow.aqu().r()["interface_up_dh_console_numberOfEntries"] = 0;
			serviceOrThrow.aqu().r()["interface_up_dh_console_reset"] = false;
			serviceOrThrow.aqu().r()["interface_up_dh_console_entryList"] = "";
			for (int i = 1; i <= 8; i++)
			{
				serviceOrThrow.aqu().r()["interface_up_dh_console_option" + i.ToString() + "Selected"] = false;
			}
			return;
		}
		if (value2 <= 3)
		{
			text += value.ToString();
			serviceOrThrow.aqu().r()["interface_up_dh_console_entryList"] = text;
		}
		if (value2 >= 3)
		{
			if (!value3)
			{
				if (text == "673382")
				{
					serviceOrThrow.aqu().r()["interface_up_dh_console_passedFirstSet"] = true;
				}
			}
			else if (!value4)
			{
				if (text == "768925")
				{
					serviceOrThrow.aqu().r()["interface_up_dh_console_passedSecondSet"] = true;
				}
			}
			else if (!value5 && text == "795511")
			{
				serviceOrThrow.aqu().r()["interface_up_dh_console_passedThirdSet"] = true;
				c5x c5x = new ar7(new Guid("9e07d773-1dea-47e4-9c01-9eae4f4e3e0a"), A_0.Area).ao() as c5x;
				if (c5x != null)
				{
					axh aspect = c5x.GetAspect<axh>();
					if (aspect != null)
					{
						aspect.a(null, true, null);
					}
				}
			}
			serviceOrThrow.aqu().r()["interface_up_dh_console_currentEntry"] = 0;
			serviceOrThrow.aqu().r()["interface_up_dh_console_numberOfEntries"] = 0;
			serviceOrThrow.aqu().r()["interface_up_dh_console_shouldShowWorking"] = true;
			serviceOrThrow.aqu().r()["interface_up_dh_console_entryList"] = "";
			for (int j = 1; j <= 8; j++)
			{
				serviceOrThrow.aqu().r()["interface_up_dh_console_option" + j.ToString() + "Selected"] = false;
			}
		}
	}
}
