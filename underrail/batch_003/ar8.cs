using System;
using System.Runtime.Serialization;

// Token: 0x02000FE1 RID: 4065
[eiz("O1")]
[Serializable]
public sealed class ar8 : esc
{
	// Token: 0x060053B3 RID: 21427 RVA: 0x002514EC File Offset: 0x0024F6EC
	private ar8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("O1:L");
	}

	// Token: 0x060053B4 RID: 21428 RVA: 0x00251508 File Offset: 0x0024F708
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("O1:L", this.a);
	}

	// Token: 0x060053B5 RID: 21429 RVA: 0x00251524 File Offset: 0x0024F724
	public int a()
	{
		return this.a;
	}

	// Token: 0x060053B6 RID: 21430 RVA: 0x0025152C File Offset: 0x0024F72C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060053B7 RID: 21431 RVA: 0x00251538 File Offset: 0x0024F738
	public ar8()
	{
	}

	// Token: 0x060053B8 RID: 21432 RVA: 0x00251540 File Offset: 0x0024F740
	public ar8(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060053B9 RID: 21433 RVA: 0x00251554 File Offset: 0x0024F754
	public override int d5(bq8 A_0, bq8 A_1)
	{
		c5x classPropertyValue = A_0.GetClassPropertyValue<c5x>("_Target");
		if (classPropertyValue != null)
		{
			yf yf = classPropertyValue.GetAspect<bim>() as yf;
			if (yf != null)
			{
				yf.a(new int?(this.a));
			}
		}
		A_1.set_Item("AccessLevel", this.a);
		return 0;
	}

	// Token: 0x04002220 RID: 8736
	private int a;
}
