using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020004E3 RID: 1251
[eiz("PHIC")]
[Serializable]
public sealed class dou : dnh, ISerializable
{
	// Token: 0x0600203D RID: 8253 RVA: 0x000AF4FC File Offset: 0x000AD6FC
	private dou(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("PHIC:IC");
			this.b = A_0.GetInt32("PHIC:S");
			this.c = A_0.GetBoolean("PHIC:I");
			this.d = A_0.GetBoolean("PHIC:SG");
			if (ell.a() >= 120)
			{
				this.e = (A_0.GetValue("PHIC:N", typeof(Guid?)) as Guid?);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(dou))
			{
				this.a = A_0.GetString("_ItemCode");
				this.b = A_0.GetInt32("_Stacks");
				this.c = A_0.GetBoolean("_Inverse");
				this.d = A_0.GetBoolean("_SearchGear");
				return;
			}
			this.a = A_0.GetString("PlayerHasItemCondition+_ItemCode");
			this.b = A_0.GetInt32("PlayerHasItemCondition+_Stacks");
			this.c = A_0.GetBoolean("PlayerHasItemCondition+_Inverse");
			this.d = A_0.GetBoolean("PlayerHasItemCondition+_SearchGear");
		}
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x000AF644 File Offset: 0x000AD844
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PHIC:IC", this.a);
		info.AddValue("PHIC:S", this.b);
		info.AddValue("PHIC:I", this.c);
		info.AddValue("PHIC:SG", this.d);
		info.AddValue("PHIC:N", this.e);
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000AF6B4 File Offset: 0x000AD8B4
	public string d()
	{
		return this.a;
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x000AF6BC File Offset: 0x000AD8BC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002041 RID: 8257 RVA: 0x000AF6C8 File Offset: 0x000AD8C8
	public int c()
	{
		return this.b;
	}

	// Token: 0x06002042 RID: 8258 RVA: 0x000AF6D0 File Offset: 0x000AD8D0
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002043 RID: 8259 RVA: 0x000AF6DC File Offset: 0x000AD8DC
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06002044 RID: 8260 RVA: 0x000AF6E4 File Offset: 0x000AD8E4
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x000AF6F0 File Offset: 0x000AD8F0
	public bool e()
	{
		return this.d;
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x000AF6F8 File Offset: 0x000AD8F8
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002047 RID: 8263 RVA: 0x000AF704 File Offset: 0x000AD904
	public Guid? b()
	{
		return this.e;
	}

	// Token: 0x06002048 RID: 8264 RVA: 0x000AF70C File Offset: 0x000AD90C
	public void a(Guid? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06002049 RID: 8265 RVA: 0x000AF718 File Offset: 0x000AD918
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.a != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
		{
			efk efk = null;
			if (this.e != null)
			{
				EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(serviceOrThrow.aqu().v().b().Area, this.e.Value);
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
				flag = (Enumerable.Sum<d5o>(efk.b(this.a, this.b, this.d), new Func<d5o, int>(dou.a.a.a)) >= this.b);
			}
		}
		return flag ^ this.c;
	}

	// Token: 0x0600204A RID: 8266 RVA: 0x000AF83C File Offset: 0x000ADA3C
	public override string ToString()
	{
		string text = string.Format("{0} имеет \"{1}\"", (this.e != null) ? "npc" : "player", this.a);
		if (this.b > 1)
		{
			text = text + " x " + this.b.ToString();
		}
		return text;
	}

	// Token: 0x0600204B RID: 8267 RVA: 0x000AF8A0 File Offset: 0x000ADAA0
	public dou()
	{
	}

	// Token: 0x04001406 RID: 5126
	private string a;

	// Token: 0x04001407 RID: 5127
	private int b = 1;

	// Token: 0x04001408 RID: 5128
	private bool c;

	// Token: 0x04001409 RID: 5129
	private bool d = true;

	// Token: 0x0400140A RID: 5130
	private Guid? e;

	// Token: 0x020004E4 RID: 1252
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600204E RID: 8270 RVA: 0x000AF8CC File Offset: 0x000ADACC
		internal int a(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x0400140B RID: 5131
		public static readonly dou.a a = new dou.a();

		// Token: 0x0400140C RID: 5132
		public static Func<d5o, int> b;
	}
}
