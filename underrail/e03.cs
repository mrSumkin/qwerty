using System;
using System.Collections.Generic;
using System.Drawing;

// Token: 0x02000133 RID: 307
internal sealed class e03 : a4y
{
	// Token: 0x06000779 RID: 1913 RVA: 0x0001FFA4 File Offset: 0x0001E1A4
	public override string u3()
	{
		return "GetDisplaySettings";
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x0001FFAC File Offset: 0x0001E1AC
	public override string u5()
	{
		return "Gets the current display settings.";
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x0001FFB8 File Offset: 0x0001E1B8
	public override void u6(string[] A_0, dk1 A_1)
	{
		bef service = bpo.GetService<bef>();
		if (service != null)
		{
			esj esj = service.k0();
			string a_ = string.Concat(new string[]
			{
				"Width: ",
				esj.c.ToString(),
				", Height: ",
				esj.d.ToString(),
				", Format: ",
				service.k1().ToString()
			});
			A_1.y9(Color.Black, 12, FontStyle.Regular, a_);
		}
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00020040 File Offset: 0x0001E240
	public override ICollection<string> u4()
	{
		return new string[]
		{
			"disp"
		};
	}
}
