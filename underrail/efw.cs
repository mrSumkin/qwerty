using System;
using System.Collections.Generic;
using TimelapseVertigo.Common.Settings;

// Token: 0x020004B1 RID: 1201
public static class efw
{
	// Token: 0x06001E7C RID: 7804 RVA: 0x000A9B9C File Offset: 0x000A7D9C
	static efw()
	{
		foreach (object obj in Enum.GetValues(typeof(DisplayResolution)))
		{
			DisplayResolution displayResolution = (DisplayResolution)obj;
			string[] array = displayResolution.ToString().Substring(1).Split(new char[]
			{
				'x'
			});
			int num = Convert.ToInt32(array[0]);
			int num2 = Convert.ToInt32(array[1]);
			UiSize uiSize;
			if (num2 > 1200)
			{
				uiSize = UiSize.Huge;
			}
			else if (num2 > 800 && num >= 1200)
			{
				uiSize = UiSize.Large;
			}
			else
			{
				uiSize = UiSize.Small;
			}
			float a_ = 1f;
			InterfaceElementSize2 a_2;
			if (num2 > 1440)
			{
				a_2 = InterfaceElementSize2.Huge;
				a_ = 2f;
			}
			else if (num2 > 1080)
			{
				a_2 = InterfaceElementSize2.ExtraLarge;
				a_ = 1.5f;
			}
			else if (num2 == 1080)
			{
				a_2 = InterfaceElementSize2.Large;
				a_ = 1.5f;
			}
			else if (num2 >= 800 && num >= 1200)
			{
				a_2 = InterfaceElementSize2.Large;
			}
			else
			{
				a_2 = InterfaceElementSize2.Small;
			}
			efw.a[displayResolution] = new egd(displayResolution, num, num2, uiSize, uiSize, a_2, a_);
		}
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x000A9D18 File Offset: 0x000A7F18
	public static egd a(DisplayResolution A_0)
	{
		return efw.a[A_0];
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x000A9D28 File Offset: 0x000A7F28
	public static List<egd> a()
	{
		List<egd> list = new List<egd>();
		foreach (object obj in Enum.GetValues(typeof(DisplayResolution)))
		{
			DisplayResolution a_ = (DisplayResolution)obj;
			list.Add(efw.a(a_));
		}
		return list;
	}

	// Token: 0x04001372 RID: 4978
	private static Dictionary<DisplayResolution, egd> a = new Dictionary<DisplayResolution, egd>();
}
