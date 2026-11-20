using System;
using System.Runtime.Serialization;

// Token: 0x020019AE RID: 6574
[eiz("CFDBME")]
[Serializable]
public sealed class eh4 : cdh, ISerializable, d7s
{
	// Token: 0x06008C81 RID: 35969 RVA: 0x003914D8 File Offset: 0x0038F6D8
	private eh4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CFDBME:B");
	}

	// Token: 0x06008C82 RID: 35970 RVA: 0x003914F4 File Offset: 0x0038F6F4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CFDBME:B", this.a);
	}

	// Token: 0x06008C83 RID: 35971 RVA: 0x00391510 File Offset: 0x0038F710
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008C84 RID: 35972 RVA: 0x00391518 File Offset: 0x0038F718
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008C85 RID: 35973 RVA: 0x00391524 File Offset: 0x0038F724
	public eh4()
	{
	}

	// Token: 0x06008C86 RID: 35974 RVA: 0x0039152C File Offset: 0x0038F72C
	public override string b2()
	{
		return string.Format("Увеличивает бонус к урону от направленного огня на {0}% за ед. эффекта.", Convert.ToInt32((double)this.a * enf.a * 100.0));
	}

	// Token: 0x06008C87 RID: 35975 RVA: 0x0039155C File Offset: 0x0038F75C
	public override d3e b3()
	{
		eh4 eh = new eh4();
		this.xx(eh);
		return eh;
	}

	// Token: 0x06008C88 RID: 35976 RVA: 0x00391578 File Offset: 0x0038F778
	public void cn(d3e A_0)
	{
		eh4 eh = A_0 as eh4;
		if (eh != null)
		{
			this.a = Math.Max(0, this.a + eh.a);
		}
	}

	// Token: 0x06008C89 RID: 35977 RVA: 0x003915AC File Offset: 0x0038F7AC
	public bool co(d3e A_0)
	{
		return A_0 is eh4;
	}

	// Token: 0x06008C8A RID: 35978 RVA: 0x003915B8 File Offset: 0x0038F7B8
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((eh4)A_0).a = this.a;
	}

	// Token: 0x0400379E RID: 14238
	private new int a;
}
