using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000FD6 RID: 4054
[eiz("MHIC")]
[Serializable]
public sealed class gs : dnh, ISerializable
{
	// Token: 0x0600536C RID: 21356 RVA: 0x00250628 File Offset: 0x0024E828
	private gs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("MHIC:IC");
		this.b = A_0.GetInt32("MHIC:S");
		this.c = A_0.GetBoolean("MHIC:I");
	}

	// Token: 0x0600536D RID: 21357 RVA: 0x00250678 File Offset: 0x0024E878
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MHIC:IC", this.a);
		info.AddValue("MHIC:S", this.b);
		info.AddValue("MHIC:I", this.c);
	}

	// Token: 0x0600536E RID: 21358 RVA: 0x002506C0 File Offset: 0x0024E8C0
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600536F RID: 21359 RVA: 0x002506C8 File Offset: 0x0024E8C8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005370 RID: 21360 RVA: 0x002506D4 File Offset: 0x0024E8D4
	public int c()
	{
		return this.b;
	}

	// Token: 0x06005371 RID: 21361 RVA: 0x002506DC File Offset: 0x0024E8DC
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005372 RID: 21362 RVA: 0x002506E8 File Offset: 0x0024E8E8
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06005373 RID: 21363 RVA: 0x002506F0 File Offset: 0x0024E8F0
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005374 RID: 21364 RVA: 0x002506FC File Offset: 0x0024E8FC
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (this.a != null)
		{
			dvp aspect = A_0.GetClassPropertyValue<b0b>("_Target").GetAspect<dvp>();
			if (aspect == null)
			{
				aspect = A_0.GetClassPropertyValue<b0b>(c49.a).GetAspect<dvp>();
			}
			if (aspect != null)
			{
				aspect.aqc(false);
				flag = (Enumerable.Sum<d5o>(aspect.ap7().z2().a(this.a, this.b), new Func<d5o, int>(gs.a.a.a)) >= this.b);
			}
		}
		return flag ^ this.c;
	}

	// Token: 0x06005375 RID: 21365 RVA: 0x002507A4 File Offset: 0x0024E9A4
	public gs()
	{
	}

	// Token: 0x0400220C RID: 8716
	private string a;

	// Token: 0x0400220D RID: 8717
	private int b = 1;

	// Token: 0x0400220E RID: 8718
	private bool c;

	// Token: 0x02000FD7 RID: 4055
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06005378 RID: 21368 RVA: 0x002507C8 File Offset: 0x0024E9C8
		internal int a(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x0400220F RID: 8719
		public static readonly gs.a a = new gs.a();

		// Token: 0x04002210 RID: 8720
		public static Func<d5o, int> b;
	}
}
