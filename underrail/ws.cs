using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02000F69 RID: 3945
[eiz("BOBLEVEA")]
[Serializable]
public sealed class ws : Aspect<c5x>, c98
{
	// Token: 0x06004FF5 RID: 20469 RVA: 0x0023E3E8 File Offset: 0x0023C5E8
	private ws(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 684)
		{
			this.a = A_0.GetBoolean("BOBLEVEA:E");
		}
		else
		{
			this.a = true;
		}
		this.b = (A_0.GetValue("BOBLEVEA:B", typeof(float?)) as float?);
		this.c = A_0.GetSingle("BOBLEVEA:A");
		this.d = A_0.GetInt32("BOBLEVEA:P");
		this.e = A_0.GetInt32("BOBLEVEA:T");
	}

	// Token: 0x06004FF6 RID: 20470 RVA: 0x0023E488 File Offset: 0x0023C688
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BOBLEVEA:E", this.a);
		info.AddValue("BOBLEVEA:B", this.b);
		info.AddValue("BOBLEVEA:A", this.c);
		info.AddValue("BOBLEVEA:P", this.d);
		info.AddValue("BOBLEVEA:T", this.e);
	}

	// Token: 0x06004FF7 RID: 20471 RVA: 0x0023E4F8 File Offset: 0x0023C6F8
	public bool d()
	{
		return this.a;
	}

	// Token: 0x06004FF8 RID: 20472 RVA: 0x0023E500 File Offset: 0x0023C700
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004FF9 RID: 20473 RVA: 0x0023E50C File Offset: 0x0023C70C
	public float b()
	{
		return this.c;
	}

	// Token: 0x06004FFA RID: 20474 RVA: 0x0023E514 File Offset: 0x0023C714
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06004FFB RID: 20475 RVA: 0x0023E520 File Offset: 0x0023C720
	public int a()
	{
		return this.d;
	}

	// Token: 0x06004FFC RID: 20476 RVA: 0x0023E528 File Offset: 0x0023C728
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06004FFD RID: 20477 RVA: 0x0023E534 File Offset: 0x0023C734
	public ws(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06004FFE RID: 20478 RVA: 0x0023E548 File Offset: 0x0023C748
	public void r7(eds A_0)
	{
		if (this.a)
		{
			if (this.b == null)
			{
				this.b = new float?(base.a8().Location.Z);
				this.e = cuo.a.Next(this.d);
			}
			double num = Math.Sin((A_0.a.TotalMilliseconds + (double)this.e) % (double)this.d / (double)this.d * 2.0 * 3.141592653589793);
			b0b b0b = base.a8();
			float x = base.a8().Location.X;
			float y = base.a8().Location.Y;
			float? num2 = this.b;
			b0b.Location = new Vector3(x, y, Convert.ToSingle(((num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null) + num * (double)this.c));
			base.a8().ah();
		}
	}

	// Token: 0x0400209F RID: 8351
	private bool a = true;

	// Token: 0x040020A0 RID: 8352
	private float? b;

	// Token: 0x040020A1 RID: 8353
	private float c;

	// Token: 0x040020A2 RID: 8354
	private int d;

	// Token: 0x040020A3 RID: 8355
	private int e;
}
