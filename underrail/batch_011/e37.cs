using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common;
using Ouroboros.Common.Aspects;

// Token: 0x0200125B RID: 4699
[eiz("LTEEA")]
[Serializable]
public sealed class e37 : Aspect<c5x>, ISerializable, c98
{
	// Token: 0x060065A3 RID: 26019 RVA: 0x002B4238 File Offset: 0x002B2438
	private e37(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("LTEEA:J", typeof(List<cze>)) as List<cze>);
		this.b = A_0.GetBoolean("LTEEA:P");
		this.c = (Axis)A_0.GetValue("LTEEA:O", typeof(Axis));
		this.d = (A_0.GetValue("LTEEA:S", typeof(List<ar7>)) as List<ar7>);
		this.e = A_0.GetInt32("LTEEA:I");
		this.f = A_0.GetDouble("LTEEA:C");
	}

	// Token: 0x060065A4 RID: 26020 RVA: 0x002B42F8 File Offset: 0x002B24F8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LTEEA:J", this.a);
		info.AddValue("LTEEA:P", this.b);
		info.AddValue("LTEEA:O", this.c);
		info.AddValue("LTEEA:S", this.d);
		info.AddValue("LTEEA:I", this.e);
		info.AddValue("LTEEA:C", this.f);
	}

	// Token: 0x060065A5 RID: 26021 RVA: 0x002B4378 File Offset: 0x002B2578
	public List<cze> b()
	{
		return this.a;
	}

	// Token: 0x060065A6 RID: 26022 RVA: 0x002B4380 File Offset: 0x002B2580
	public void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060065A7 RID: 26023 RVA: 0x002B438C File Offset: 0x002B258C
	public bool a()
	{
		return this.b;
	}

	// Token: 0x060065A8 RID: 26024 RVA: 0x002B4394 File Offset: 0x002B2594
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060065A9 RID: 26025 RVA: 0x002B43A0 File Offset: 0x002B25A0
	public Axis d()
	{
		return this.c;
	}

	// Token: 0x060065AA RID: 26026 RVA: 0x002B43A8 File Offset: 0x002B25A8
	public void a(Axis A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060065AB RID: 26027 RVA: 0x002B43B4 File Offset: 0x002B25B4
	public int e()
	{
		return this.e;
	}

	// Token: 0x060065AC RID: 26028 RVA: 0x002B43BC File Offset: 0x002B25BC
	public void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060065AD RID: 26029 RVA: 0x002B43C8 File Offset: 0x002B25C8
	public e37(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060065AE RID: 26030 RVA: 0x002B43E8 File Offset: 0x002B25E8
	public void r7(eds A_0)
	{
		this.f = Math.Max(0.0, this.f - A_0.b.TotalMilliseconds);
		if (!base.a8().a())
		{
			foreach (ar7 ar in this.d)
			{
				if (ar.ao() != null && ar.ao().j == cgy.b)
				{
					((c5x)ar.ao()).h();
				}
			}
			this.d.Clear();
			return;
		}
		bool flag = false;
		bool flag2 = false;
		c5x a_ = null;
		int i;
		for (i = 0; i < 100; i++)
		{
			Vector3 value;
			Vector3 vector;
			if (this.d() == Axis.X)
			{
				value = new Vector3(0.25f, 0f, 0f);
				vector = new Vector3(0.25f, 0.1f, 0.1f);
			}
			else
			{
				value = new Vector3(0f, 0.25f, 0f);
				vector = new Vector3(0.1f, 0.25f, 0.1f);
			}
			Vector3 vector2 = base.a8().Location + (float)i * value;
			ar7 ar2 = null;
			if (this.d.Count > i)
			{
				ar2 = this.d[i];
			}
			c5x c5x;
			if (ar2 == null || ar2.ao() == null)
			{
				c5x = new c5x();
				c5x.Location = vector2;
				c5x.Size = vector;
				c5x.Layer = base.a8().Layer;
				c5x.VisualPriority = i % 4 - 2;
				c5x.SetAspect<cd0>(new cd0(c5x)
				{
					a = string.Format("Objects\\Traps\\LaserTrap{0}Ray", this.d()),
					b = new Point(0, 0),
					g = new float?(1f)
				});
				base.a8().Area.a(c5x);
				ar2 = new ar7(c5x);
				if (i < this.d.Count)
				{
					this.d[i] = ar2;
				}
				else
				{
					this.d.Add(ar2);
				}
			}
			else
			{
				c5x = (c5x)ar2.ao();
				if (c5x.Location != vector2 || c5x.Size != vector)
				{
					c5x.Location = vector2;
					c5x.Size = vector;
					c5x.ah();
				}
			}
			float value2 = 0.7f;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				float num = d05.b(0.15f, (float)serviceOrThrow.aqu().v().BaseAbilities.Perception / 16f, 1f);
				float num3;
				if (serviceOrThrow.aqu().v().b().Area == c5x.Area)
				{
					float num2 = (float)aw1.b(serviceOrThrow.aqu().v().b(), c5x);
					num3 = d05.b(0.1f, 1f - num2 / 5f, 1f);
				}
				else
				{
					num3 = 0f;
				}
				value2 = 0.55f * num * num3;
			}
			c5x.ae = new float?(value2);
			ak1 ak = Enumerable.FirstOrDefault<ak1>(c5x.l);
			if (ak != null)
			{
				if (i % 4 == 0 && ak.Formation.c(1L))
				{
					flag = true;
				}
				foreach (b0b b0b in ak.Entities)
				{
					c5x c5x2 = (c5x)b0b;
					if (c5x2.h.b != null)
					{
						Rectangle value3 = new Rectangle((int)(c5x.Location.X * 100f), (int)(c5x.Location.Y * 100f), (int)(vector.X * 100f), (int)(vector.Y * 100f));
						Rectangle rectangle = Rectangle.Intersect(new Rectangle((int)((c5x2.Location.X + 0.25f) * 100f), (int)((c5x2.Location.Y + 0.25f) * 100f), (int)((c5x2.Size.X - 0.25f) * 100f), (int)((c5x2.Size.Y - 0.25f) * 100f)), value3);
						if (rectangle.Width > 0 && rectangle.Height > 0)
						{
							flag = true;
							if (!this.b || c5x2.IsPlayer)
							{
								flag2 = true;
								a_ = c5x2;
								flag = true;
							}
						}
					}
				}
			}
			if (flag)
			{
				break;
			}
		}
		if (this.d.Count > i + 1)
		{
			for (int j = i + 1; j < this.d.Count; j++)
			{
				ar7 ar3 = this.d[j];
				if (ar3.ao() != null && ar3.ao().j == cgy.b)
				{
					((c5x)ar3.ao()).h();
				}
			}
			this.d.RemoveRange(i + 1, this.d.Count - (i + 1));
		}
		if (flag2 && this.f == 0.0)
		{
			if (this.a != null && this.a.Count > 0)
			{
				Dictionary<string, object> a_2 = a3f.a(base.a8());
				foreach (cze cze in this.a)
				{
					cze.ym(a_, base.a8(), a_2);
				}
			}
			this.f = (double)this.e;
		}
	}

	// Token: 0x04002A4A RID: 10826
	private List<cze> a = new List<cze>();

	// Token: 0x04002A4B RID: 10827
	private bool b;

	// Token: 0x04002A4C RID: 10828
	private Axis c;

	// Token: 0x04002A4D RID: 10829
	private List<ar7> d = new List<ar7>();

	// Token: 0x04002A4E RID: 10830
	private int e;

	// Token: 0x04002A4F RID: 10831
	private double f;
}
