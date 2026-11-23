using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020011E7 RID: 4583
[eiz("BTG")]
[Serializable]
public sealed class te : b79, ISerializable
{
	// Token: 0x06006257 RID: 25175 RVA: 0x002A8940 File Offset: 0x002A6B40
	private te(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() < 364)
		{
			base.b(A_0.GetValue("BTG:N", typeof(TimeSpan?)) as TimeSpan?);
			base.a((TimeSpan)A_0.GetValue("BTG:R", typeof(TimeSpan)));
		}
		this.a = (Vector3)A_0.GetValue("BTG:S", typeof(Vector3));
		this.b = (Vector3)A_0.GetValue("BTG:D", typeof(Vector3));
	}

	// Token: 0x06006258 RID: 25176 RVA: 0x002A89EC File Offset: 0x002A6BEC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BTG:S", this.a);
		info.AddValue("BTG:D", this.b);
	}

	// Token: 0x06006259 RID: 25177 RVA: 0x002A8A24 File Offset: 0x002A6C24
	public Vector3 b()
	{
		return this.a;
	}

	// Token: 0x0600625A RID: 25178 RVA: 0x002A8A2C File Offset: 0x002A6C2C
	public void b(Vector3 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600625B RID: 25179 RVA: 0x002A8A38 File Offset: 0x002A6C38
	public Vector3 a()
	{
		return this.b;
	}

	// Token: 0x0600625C RID: 25180 RVA: 0x002A8A40 File Offset: 0x002A6C40
	public void a(Vector3 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600625D RID: 25181 RVA: 0x002A8A4C File Offset: 0x002A6C4C
	public te()
	{
	}

	// Token: 0x0600625E RID: 25182 RVA: 0x002A8A58 File Offset: 0x002A6C58
	protected override void li()
	{
		if (base.Area != null && base.Area.Zone != null)
		{
			double num = 1.0;
			double num2 = 0.5;
			int num3 = 8 + cuo.a.Next(10);
			qy qy = new qy();
			for (int i = 0; i < num3; i++)
			{
				Vector3 a_ = this.a + new Vector3((float)(-(float)num + cuo.a.NextDouble() * num * 2.0), (float)(-(float)num + cuo.a.NextDouble() * num * 2.0), (float)(-(float)num2 + cuo.a.NextDouble() * num2 * 2.0));
				Vector3 a_2 = this.b + new Vector3((float)(-(float)num + cuo.a.NextDouble() * num * 2.0), (float)(-(float)num + cuo.a.NextDouble() * num * 2.0), (float)(-(float)num2 + cuo.a.NextDouble() * num2 * 2.0));
				qy.ad().Add(new a6c(a_, a_2, base.Area, "Bats" + (1 + cuo.a.Next(3)).ToString(), null));
				qy.ad().Add(new bm3(25 + cuo.a.Next(12)));
			}
			base.Area.Zone.ActionManager.g9(qy, atp.a);
		}
	}

	// Token: 0x040029A7 RID: 10663
	private Vector3 a;

	// Token: 0x040029A8 RID: 10664
	private Vector3 b;
}
