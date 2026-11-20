using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200143D RID: 5181
[eiz("KA")]
[Serializable]
public sealed class dvo : dvv, ISerializable
{
	// Token: 0x0600746E RID: 29806 RVA: 0x00316170 File Offset: 0x00314370
	private dvo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("KA:ER", typeof(ar7));
			this.b = (Vector3)A_0.GetValue("KA:D", typeof(Vector3));
			this.c = A_0.GetSingle("KA:D1");
			return;
		}
		if (base.GetType() == typeof(dvo))
		{
			this.a = (ar7)A_0.GetValue("_EntityRef", typeof(ar7));
			this.b = (Vector3)A_0.GetValue("_Direction", typeof(Vector3));
			this.c = A_0.GetSingle("_Distance");
			return;
		}
		this.a = (ar7)A_0.GetValue("KnockbackAction+_EntityRef", typeof(ar7));
		this.b = (Vector3)A_0.GetValue("KnockbackAction+_Direction", typeof(Vector3));
		this.c = A_0.GetSingle("KnockbackAction+_Distance");
	}

	// Token: 0x0600746F RID: 29807 RVA: 0x003162A0 File Offset: 0x003144A0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("KA:ER", this.a);
		info.AddValue("KA:D", this.b);
		info.AddValue("KA:D1", this.c);
	}

	// Token: 0x06007470 RID: 29808 RVA: 0x003162F0 File Offset: 0x003144F0
	private c5x a()
	{
		return this.a.ao() as c5x;
	}

	// Token: 0x06007471 RID: 29809 RVA: 0x00316304 File Offset: 0x00314504
	public dvo(c5x A_0, Vector3 A_1, float A_2)
	{
		this.a = new ar7(A_0);
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x06007472 RID: 29810 RVA: 0x0031632C File Offset: 0x0031452C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() == null || this.a().Zone == null || this.a().j.b == null)
		{
			return dc4.e;
		}
		float num = this.c;
		List<Plane> list = new List<Plane>();
		list.Add(new Plane(new Vector3(0f, 1f, 0f), 0f));
		list.Add(new Plane(new Vector3(0f, -1f, 0f), (float)this.a().Area.Size.d - this.a().Size.Y));
		list.Add(new Plane(new Vector3(1f, 0f, 0f), 0f));
		list.Add(new Plane(new Vector3(-1f, 0f, 0f), (float)this.a().Area.Size.c - this.a().Size.X));
		Ray ray = new Ray(this.a().Location, this.b);
		foreach (Plane plane in list)
		{
			float? num2 = ray.Intersects(plane);
			if (num2 != null)
			{
				num = Math.Min(num, num2.Value);
			}
		}
		Vector3 a_ = this.a().Location + this.b * num;
		bpr bpr = new bpr(this.a().j.b, a_, new float?((float)10), null);
		bpr.b(false);
		this.a().Zone.ActionManager.g9(bpr, atp.a);
		return dc4.c;
	}

	// Token: 0x04002F94 RID: 12180
	private new ar7 a;

	// Token: 0x04002F95 RID: 12181
	private Vector3 b;

	// Token: 0x04002F96 RID: 12182
	private float c;
}
