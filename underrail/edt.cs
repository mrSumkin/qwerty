using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x020006EC RID: 1772
[eiz("HG")]
[Serializable]
public sealed class edt : y8, ISerializable
{
	// Token: 0x06002DB9 RID: 11705 RVA: 0x00104190 File Offset: 0x00102390
	private edt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002DBA RID: 11706 RVA: 0x0010419C File Offset: 0x0010239C
	public edt()
	{
	}

	// Token: 0x06002DBB RID: 11707 RVA: 0x001041A8 File Offset: 0x001023A8
	protected override List<coh> a2()
	{
		int num;
		int num2;
		this.aj5(out num, out num2);
		int num3;
		if (num <= num2)
		{
			num3 = zp.a.Next(num, num2 + 1) / 6 + 1;
		}
		else
		{
			num3 = num / 6 + 1;
		}
		num3 = Math.Min(num3, 3);
		d48 d = new d48(new LibraryItemDefinitionProvider<dj3>("Devices\\Haxxor" + ((num3 > 1) ? num3.ToString() : "")));
		d.MaxBatteryLegacy = 10 + 20 * num3;
		return new List<coh>
		{
			d
		};
	}

	// Token: 0x06002DBC RID: 11708 RVA: 0x00104234 File Offset: 0x00102434
	public override aw4 a1()
	{
		edt edt = new edt();
		this.rg(edt);
		return edt;
	}

	// Token: 0x040019CA RID: 6602
	private new const string a = "Haxxor Generator";
}
