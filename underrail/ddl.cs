using System;
using System.Runtime.Serialization;

// Token: 0x02001A0D RID: 6669
[eiz("MFFE")]
[Serializable]
public sealed class ddl : dts, ISerializable, d7s
{
	// Token: 0x0600900C RID: 36876 RVA: 0x003995E0 File Offset: 0x003977E0
	private ddl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600900D RID: 36877 RVA: 0x003995EC File Offset: 0x003977EC
	public ddl()
	{
	}

	// Token: 0x0600900E RID: 36878 RVA: 0x003995F4 File Offset: 0x003977F4
	public ddl(int A_0) : base(A_0)
	{
	}

	// Token: 0x0600900F RID: 36879 RVA: 0x00399600 File Offset: 0x00397800
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		nw nw = A_0.a().Defense;
		nw.d(nw.ab() + base.c());
	}

	// Token: 0x06009010 RID: 36880 RVA: 0x00399638 File Offset: 0x00397838
	public void cn(d3e A_0)
	{
		ddl ddl = A_0 as ddl;
		if (ddl != null)
		{
			base.a(base.c() + ddl.c());
		}
	}

	// Token: 0x06009011 RID: 36881 RVA: 0x00399668 File Offset: 0x00397868
	public bool co(d3e A_0)
	{
		ddl ddl = A_0 as ddl;
		return ddl != null && ddl.Condition == base.Condition;
	}

	// Token: 0x06009012 RID: 36882 RVA: 0x00399694 File Offset: 0x00397894
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyFortitudeFlat_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyFortitudeFlat_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x06009013 RID: 36883 RVA: 0x003996F0 File Offset: 0x003978F0
	public override d3e b3()
	{
		ddl ddl = new ddl();
		this.xx(ddl);
		return ddl;
	}
}
