using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators.Items;
using TimelapseVertigo.Rules.Items;

// Token: 0x020006FD RID: 1789
[eiz("MIG")]
[Serializable]
public sealed class ayz : y8
{
	// Token: 0x06002E62 RID: 11874 RVA: 0x00107250 File Offset: 0x00105450
	public GrenadeOrMineType b()
	{
		return this.a;
	}

	// Token: 0x06002E63 RID: 11875 RVA: 0x00107258 File Offset: 0x00105458
	public void b(GrenadeOrMineType A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E64 RID: 11876 RVA: 0x00107264 File Offset: 0x00105464
	public ayz()
	{
	}

	// Token: 0x06002E65 RID: 11877 RVA: 0x0010726C File Offset: 0x0010546C
	public ayz(GrenadeOrMineType A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E66 RID: 11878 RVA: 0x0010727C File Offset: 0x0010547C
	private ayz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (GrenadeOrMineType)A_0.GetValue("MIG:GT", typeof(GrenadeOrMineType));
	}

	// Token: 0x06002E67 RID: 11879 RVA: 0x001072A8 File Offset: 0x001054A8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MIG:GT", this.a);
	}

	// Token: 0x06002E68 RID: 11880 RVA: 0x001072CC File Offset: 0x001054CC
	protected override List<coh> a2()
	{
		GrenadeOrMineType a_ = this.a();
		d48 item = new d48(new LibraryItemDefinitionProvider<c4j>("traps\\" + a_.ToString() + "mine" + this.a(a_).ToString()));
		return new List<coh>
		{
			item
		};
	}

	// Token: 0x06002E69 RID: 11881 RVA: 0x00107324 File Offset: 0x00105524
	public override aw4 a1()
	{
		return new ayz
		{
			a = this.a
		};
	}

	// Token: 0x06002E6A RID: 11882 RVA: 0x0010733C File Offset: 0x0010553C
	private int a(GrenadeOrMineType A_0)
	{
		if (A_0 == GrenadeOrMineType.Emp)
		{
			return 1;
		}
		int num = base.i();
		return d05.a(1, num / 5, 5);
	}

	// Token: 0x06002E6B RID: 11883 RVA: 0x00107364 File Offset: 0x00105564
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

	// Token: 0x040019E4 RID: 6628
	private new GrenadeOrMineType a;
}
