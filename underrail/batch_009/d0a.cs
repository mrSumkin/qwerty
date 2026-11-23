using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x020006ED RID: 1773
[eiz("LG")]
[Serializable]
public sealed class d0a : y8, ISerializable
{
	// Token: 0x06002DBD RID: 11709 RVA: 0x00104250 File Offset: 0x00102450
	private d0a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002DBE RID: 11710 RVA: 0x00104260 File Offset: 0x00102460
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
		d48 item = new d48(new LibraryItemDefinitionProvider<dj3>("Devices\\Lockpick" + ((num3 > 1) ? num3.ToString() : "")));
		return new List<coh>
		{
			item
		};
	}

	// Token: 0x06002DBF RID: 11711 RVA: 0x001042E0 File Offset: 0x001024E0
	public d0a()
	{
	}

	// Token: 0x06002DC0 RID: 11712 RVA: 0x001042EC File Offset: 0x001024EC
	public override aw4 a1()
	{
		d0a d0a = new d0a();
		this.rg(d0a);
		return d0a;
	}

	// Token: 0x040019CB RID: 6603
	private new const string a = "Lockpick Generator";
}
