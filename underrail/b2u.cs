using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020004CA RID: 1226
[eiz("CHIEC")]
[Serializable]
public sealed class b2u : dnh, ISerializable
{
	// Token: 0x06001F69 RID: 8041 RVA: 0x000AD3A0 File Offset: 0x000AB5A0
	private b2u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("CHIEC:IC");
		this.b = A_0.GetBoolean("CHIEC:I");
		this.c = (A_0.GetValue("CHIEC:N", typeof(Guid?)) as Guid?);
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x000AD3FC File Offset: 0x000AB5FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CHIEC:IC", this.a);
		info.AddValue("CHIEC:I", this.b);
		info.AddValue("CHIEC:N", this.c);
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x000AD44C File Offset: 0x000AB64C
	public string b()
	{
		return this.a;
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x000AD454 File Offset: 0x000AB654
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x000AD460 File Offset: 0x000AB660
	public bool c()
	{
		return this.b;
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x000AD468 File Offset: 0x000AB668
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x000AD474 File Offset: 0x000AB674
	public Guid? a()
	{
		return this.c;
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x000AD47C File Offset: 0x000AB67C
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x000AD488 File Offset: 0x000AB688
	public b2u()
	{
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x000AD490 File Offset: 0x000AB690
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.a != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
		{
			efk efk = null;
			if (this.c != null)
			{
				EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(serviceOrThrow.aqu().v().b().Area, this.c.Value);
				if (entityAspectReference.ao() != null)
				{
					efk = entityAspectReference.ao().aa();
				}
			}
			else
			{
				efk = serviceOrThrow.aqu().v();
			}
			if (efk != null)
			{
				flag = (Enumerable.Sum<d5o>(efk.Gear.i().a(this.a, 1), new Func<d5o, int>(b2u.a.a.a)) >= 1);
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x040013CB RID: 5067
	private string a;

	// Token: 0x040013CC RID: 5068
	private bool b;

	// Token: 0x040013CD RID: 5069
	private Guid? c;

	// Token: 0x020004CB RID: 1227
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06001F75 RID: 8053 RVA: 0x000AD5C4 File Offset: 0x000AB7C4
		internal int a(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x040013CE RID: 5070
		public static readonly b2u.a a = new b2u.a();

		// Token: 0x040013CF RID: 5071
		public static Func<d5o, int> b;
	}
}
