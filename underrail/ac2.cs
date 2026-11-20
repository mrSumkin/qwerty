using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators.Items;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000707 RID: 1799
[eiz("GIG")]
[Serializable]
public sealed class ac2 : y8
{
	// Token: 0x06002EB0 RID: 11952 RVA: 0x0010868C File Offset: 0x0010688C
	public GrenadeOrMineType b()
	{
		return this.a;
	}

	// Token: 0x06002EB1 RID: 11953 RVA: 0x00108694 File Offset: 0x00106894
	public void b(GrenadeOrMineType A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002EB2 RID: 11954 RVA: 0x001086A0 File Offset: 0x001068A0
	public ac2()
	{
	}

	// Token: 0x06002EB3 RID: 11955 RVA: 0x001086A8 File Offset: 0x001068A8
	public ac2(GrenadeOrMineType A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002EB4 RID: 11956 RVA: 0x001086B8 File Offset: 0x001068B8
	private ac2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (GrenadeOrMineType)A_0.GetValue("GIG:GT", typeof(GrenadeOrMineType));
	}

	// Token: 0x06002EB5 RID: 11957 RVA: 0x001086E4 File Offset: 0x001068E4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GIG:GT", this.a);
	}

	// Token: 0x06002EB6 RID: 11958 RVA: 0x00108708 File Offset: 0x00106908
	protected override List<coh> a2()
	{
		GrenadeOrMineType a_ = this.a();
		acz item = new acz(new LibraryItemDefinitionProvider<dxw>("grenades\\" + a_.ToString() + this.a(a_).ToString()));
		return new List<coh>
		{
			item
		};
	}

	// Token: 0x06002EB7 RID: 11959 RVA: 0x0010875C File Offset: 0x0010695C
	public override aw4 a1()
	{
		ac2 ac = new ac2();
		this.rg(ac);
		return ac;
	}

	// Token: 0x06002EB8 RID: 11960 RVA: 0x00108778 File Offset: 0x00106978
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		((ac2)A_0).a = this.a;
	}

	// Token: 0x06002EB9 RID: 11961 RVA: 0x00108798 File Offset: 0x00106998
	private int a(GrenadeOrMineType A_0)
	{
		if (A_0 == GrenadeOrMineType.Emp)
		{
			return 1;
		}
		int num = base.i();
		return d05.a(1, num / 5, 3);
	}

	// Token: 0x06002EBA RID: 11962 RVA: 0x001087C0 File Offset: 0x001069C0
	private GrenadeOrMineType a()
	{
		GrenadeOrMineType result;
		if (this.a == GrenadeOrMineType.Any)
		{
			result = (GrenadeOrMineType)zp.a.Next(1, 4);
		}
		else
		{
			result = this.a;
		}
		return result;
	}

	// Token: 0x040019F9 RID: 6649
	private new GrenadeOrMineType a;
}
