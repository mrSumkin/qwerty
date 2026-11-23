using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200128A RID: 4746
[a(typeof(bim))]
[eiz("SKGRMEA")]
[Serializable]
public sealed class bli : bim
{
	// Token: 0x06006734 RID: 26420 RVA: 0x002BC70C File Offset: 0x002BA90C
	private bli(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("SKGRMEA:I");
		this.b = A_0.GetBoolean("SKGRMEA:C");
		this.c = A_0.GetInt32("SKGRMEA:P");
	}

	// Token: 0x06006735 RID: 26421 RVA: 0x002BC754 File Offset: 0x002BA954
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SKGRMEA:I", this.a);
		info.AddValue("SKGRMEA:C", this.b);
		info.AddValue("SKGRMEA:P", this.c);
	}

	// Token: 0x06006736 RID: 26422 RVA: 0x002BC79C File Offset: 0x002BA99C
	public int g()
	{
		return this.a;
	}

	// Token: 0x06006737 RID: 26423 RVA: 0x002BC7A4 File Offset: 0x002BA9A4
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006738 RID: 26424 RVA: 0x002BC7B0 File Offset: 0x002BA9B0
	public bool i()
	{
		return this.b;
	}

	// Token: 0x06006739 RID: 26425 RVA: 0x002BC7B8 File Offset: 0x002BA9B8
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600673A RID: 26426 RVA: 0x002BC7C4 File Offset: 0x002BA9C4
	public int f()
	{
		return this.c;
	}

	// Token: 0x0600673B RID: 26427 RVA: 0x002BC7CC File Offset: 0x002BA9CC
	public void b(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600673C RID: 26428 RVA: 0x002BC7D8 File Offset: 0x002BA9D8
	public bli(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600673D RID: 26429 RVA: 0x002BC7E4 File Offset: 0x002BA9E4
	public override avd[] jz()
	{
		if (this.b)
		{
			avd[] array = new avd[2];
			if (this.c == 0)
			{
				array[0] = new avd("raise", "Abilities.91", "Поднять", "Наматывать бобину, чтобы поднять груз.");
			}
			else
			{
				array[0] = new avd("lower", "Abilities.92", "Опустить", "Размотать бобину, чтобы опустить груз.");
			}
			array[1] = new avd("remove", "Abilities.90", "Вытащить стопор", "Вытащите костяной стопор.");
			return array;
		}
		return null;
	}

	// Token: 0x0600673E RID: 26430 RVA: 0x002BC878 File Offset: 0x002BAA78
	public new void k()
	{
		c5x c5x = base.a8();
		c5x c5x2 = base.a8().a().ab5("GraveRope_" + this.a.ToString()) as c5x;
		int num = this.c + 1;
		if (num == 1)
		{
			if (!this.b)
			{
				num = 0;
			}
		}
		else if (num == 40 && !this.b)
		{
			num = 41;
		}
		Point point = new Point(num % 14, num / 14);
		if (c5x != null && c5x.o.b != null)
		{
			c5x.o.b.b = point;
		}
		if (c5x2 != null && c5x2.o.b != null)
		{
			c5x2.o.b.b = point;
		}
	}

	// Token: 0x0600673F RID: 26431 RVA: 0x002BC94C File Offset: 0x002BAB4C
	public bool e()
	{
		if (this.c == bli.d - 1)
		{
			return false;
		}
		this.c++;
		this.k();
		this.j();
		return true;
	}

	// Token: 0x06006740 RID: 26432 RVA: 0x002BC980 File Offset: 0x002BAB80
	public bool h()
	{
		if (this.c == 0)
		{
			return false;
		}
		this.c--;
		this.k();
		this.j();
		return true;
	}

	// Token: 0x06006741 RID: 26433 RVA: 0x002BC9AC File Offset: 0x002BABAC
	public new void j()
	{
		c5x c5x = base.a8().a().ab5("GraveArch_" + this.a.ToString()) as c5x;
		if (c5x != null && c5x.o.b != null)
		{
			int x = (c5x.o.b.b.X + 1) % 6;
			c5x.o.b.b = new Point(x, c5x.o.b.b.Y);
		}
	}

	// Token: 0x06006742 RID: 26434 RVA: 0x002BCA40 File Offset: 0x002BAC40
	protected override void mz(c5x A_0, string A_1 = null)
	{
		base.mz(A_0, A_1);
		if (A_1 == "remove")
		{
			if (this.c == 0 || this.c == 39)
			{
				base.a8().c().a("Xpbl_BoneCrankRemove");
				this.b = false;
				this.k();
				mk mk = new mk();
				mk.StaticItems.z3(new d48(ez2.CreateDefinitonProvider<dj3>("Plot\\xpbl\\boneCrank")), true);
				mk.PublishEventsForPlayer = true;
				mk.GiveTo = bvl.b;
				mk.ym(A_0, null, null);
				return;
			}
			string text = "Стопор не сдвигается с места";
			a7v.a(new h0(text + ".", new Color?(adi.m)));
			bmj.a(A_0, new d53(text, Color.Red, null, false));
			return;
		}
		else
		{
			if (A_1 == "insert")
			{
				this.b = true;
				this.k();
				return;
			}
			if (A_1 == "raise")
			{
				if (this.b)
				{
					this.b();
					return;
				}
				this.d();
				return;
			}
			else if (A_1 == "lower")
			{
				if (this.b)
				{
					this.a();
					return;
				}
				this.d();
				return;
			}
			else
			{
				if (!this.b)
				{
					this.d();
					return;
				}
				if (this.c == 39)
				{
					this.a();
					return;
				}
				this.b();
				return;
			}
		}
	}

	// Token: 0x06006743 RID: 26435 RVA: 0x002BCBAC File Offset: 0x002BADAC
	private void d()
	{
		string text = "Кажется, больше нет возможности наматывать бобину";
		a7v.a(new h0(text + ".", new Color?(adi.h)));
		bmj.a(base.a8(), new d53(text, Color.Red, null, false));
	}

	// Token: 0x06006744 RID: 26436 RVA: 0x002BCBF8 File Offset: 0x002BADF8
	private void b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["animatedSkerderGraveIndex"] = this.a;
			bpo.GetServiceOrThrow<ps>().am3("Xpbl_RaiseSkerderGrave");
		}
	}

	// Token: 0x06006745 RID: 26437 RVA: 0x002BCC48 File Offset: 0x002BAE48
	private void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["animatedSkerderGraveIndex"] = this.a;
			bpo.GetServiceOrThrow<ps>().am3("Xpbl_LowerSkerderGrave");
		}
	}

	// Token: 0x04002AB6 RID: 10934
	private new int a;

	// Token: 0x04002AB7 RID: 10935
	private bool b;

	// Token: 0x04002AB8 RID: 10936
	private int c;

	// Token: 0x04002AB9 RID: 10937
	private static readonly int d = 40;
}
