using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x020012DF RID: 4831
[eiz("HEA1")]
[Serializable]
public class b4h : Aspect<c5x>, c98, bp1, ISerializable
{
	// Token: 0x06006AE6 RID: 27366 RVA: 0x002CFF0C File Offset: 0x002CE10C
	protected b4h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			this.a = A_0.GetBoolean("_Discovered");
			this.b = A_0.GetInt32("_RequiredPerception");
			this.c = (A_0.GetValue("_CustomCondition", typeof(dth)) as dth);
			this.d = A_0.GetString("_OverrideSecretName");
			return;
		}
		this.a = A_0.GetBoolean("HEA1:D");
		this.b = A_0.GetInt32("HEA1:RP");
		this.c = (dth)A_0.GetValue("HEA1:CC", typeof(dth));
		this.d = A_0.GetString("HEA1:OSN");
		if (ell.a() >= 13)
		{
			this.e = A_0.GetString("HEA1:RS");
		}
		if (ell.a() >= 127)
		{
			this.f = (A_0.GetValue("HEA1:F", typeof(bjp)) as bjp);
		}
		if (ell.a() >= 128)
		{
			this.g = A_0.GetDouble("HEA1:X");
		}
		else
		{
			this.g = 1.0;
		}
		if (ell.a() >= 202)
		{
			di7.ReadList<cze>("HEA1:DJ", ref this.h, A_0);
		}
		else
		{
			this.h = new List<cze>();
		}
		if (ell.a() >= 595)
		{
			this.i = A_0.GetBoolean("HEA1:FI");
			return;
		}
		this.i = true;
	}

	// Token: 0x06006AE7 RID: 27367 RVA: 0x002D00C4 File Offset: 0x002CE2C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HEA1:D", this.a);
		info.AddValue("HEA1:RP", this.b);
		info.AddValue("HEA1:CC", this.c);
		info.AddValue("HEA1:OSN", this.d);
		info.AddValue("HEA1:RS", this.e);
		info.AddValue("HEA1:F", this.f);
		info.AddValue("HEA1:X", this.g);
		di7.WriteList<cze>("HEA1:DJ", this.h, info);
		info.AddValue("HEA1:FI", this.i);
	}

	// Token: 0x06006AE8 RID: 27368 RVA: 0x002D0174 File Offset: 0x002CE374
	public int g()
	{
		return this.b;
	}

	// Token: 0x06006AE9 RID: 27369 RVA: 0x002D017C File Offset: 0x002CE37C
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006AEA RID: 27370 RVA: 0x002D0188 File Offset: 0x002CE388
	public bool j()
	{
		return this.a;
	}

	// Token: 0x06006AEB RID: 27371 RVA: 0x002D0190 File Offset: 0x002CE390
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006AEC RID: 27372 RVA: 0x002D019C File Offset: 0x002CE39C
	public dth q()
	{
		return this.c;
	}

	// Token: 0x06006AED RID: 27373 RVA: 0x002D01A4 File Offset: 0x002CE3A4
	public void a(dth A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006AEE RID: 27374 RVA: 0x002D01B0 File Offset: 0x002CE3B0
	public string h()
	{
		return this.d;
	}

	// Token: 0x06006AEF RID: 27375 RVA: 0x002D01B8 File Offset: 0x002CE3B8
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006AF0 RID: 27376 RVA: 0x002D01C4 File Offset: 0x002CE3C4
	public string m()
	{
		if (!string.IsNullOrEmpty(this.d))
		{
			return this.d;
		}
		return base.a8().y8();
	}

	// Token: 0x06006AF1 RID: 27377 RVA: 0x002D01E8 File Offset: 0x002CE3E8
	public string k()
	{
		return this.e;
	}

	// Token: 0x06006AF2 RID: 27378 RVA: 0x002D01F0 File Offset: 0x002CE3F0
	public void b(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006AF3 RID: 27379 RVA: 0x002D01FC File Offset: 0x002CE3FC
	public bjp i()
	{
		return this.f;
	}

	// Token: 0x06006AF4 RID: 27380 RVA: 0x002D0204 File Offset: 0x002CE404
	public void a(bjp A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006AF5 RID: 27381 RVA: 0x002D0210 File Offset: 0x002CE410
	public double p()
	{
		return this.g;
	}

	// Token: 0x06006AF6 RID: 27382 RVA: 0x002D0218 File Offset: 0x002CE418
	public void a(double A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006AF7 RID: 27383 RVA: 0x002D0224 File Offset: 0x002CE424
	public List<cze> n()
	{
		return this.h;
	}

	// Token: 0x06006AF8 RID: 27384 RVA: 0x002D022C File Offset: 0x002CE42C
	public void b(List<cze> A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006AF9 RID: 27385 RVA: 0x002D0238 File Offset: 0x002CE438
	public bool r()
	{
		return this.i;
	}

	// Token: 0x06006AFA RID: 27386 RVA: 0x002D0240 File Offset: 0x002CE440
	public void b(bool A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06006AFB RID: 27387 RVA: 0x002D024C File Offset: 0x002CE44C
	public b4h(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006AFC RID: 27388 RVA: 0x002D0274 File Offset: 0x002CE474
	public bool a(b0b A_0, bool A_1, bool A_2 = false)
	{
		if (this.a)
		{
			return false;
		}
		if (!A_2 && this.c != null && !this.c.jh(this))
		{
			return false;
		}
		base.a8().ae = new float?(A_1 > false);
		this.a = true;
		if (this.f != null)
		{
			base.a8().TileFormationModifiers.c(this.f.b);
			base.a8().z();
		}
		foreach (cze cze in this.h)
		{
			cze.ym(A_0, base.a8(), null);
		}
		return true;
	}

	// Token: 0x06006AFD RID: 27389 RVA: 0x002D0354 File Offset: 0x002CE554
	public void o()
	{
		this.a = false;
	}

	// Token: 0x06006AFE RID: 27390 RVA: 0x002D0360 File Offset: 0x002CE560
	public void r7(eds A_0)
	{
		double totalMilliseconds = A_0.b.TotalMilliseconds;
		if (this.a && base.a8().ae != null)
		{
			float? ae = base.a8().ae;
			float num = (float)1;
			if (ae.GetValueOrDefault() < num & ae != null)
			{
				float val;
				if (this.i)
				{
					val = (float)((double)base.a8().ae.Value + totalMilliseconds * 0.15 / 255.0);
				}
				else
				{
					val = 1f;
				}
				base.a8().ae = new float?(Math.Min(1f, val));
			}
		}
	}

	// Token: 0x06006AFF RID: 27391 RVA: 0x002D041C File Offset: 0x002CE61C
	public void mx()
	{
		base.a8().e = true;
	}

	// Token: 0x06006B00 RID: 27392 RVA: 0x002D042C File Offset: 0x002CE62C
	public void my()
	{
	}

	// Token: 0x06006B01 RID: 27393 RVA: 0x002D0434 File Offset: 0x002CE634
	public b0b l()
	{
		c5x c5x = new c5x();
		c5x.q("Hidden entity SCT placeholder");
		c5x.Location = base.a8().Location;
		c5x.Size = base.a8().Size;
		c5x.Layer = aju.x;
		c5x.e = true;
		c5x.SetAspect<cd0>(new cd0(c5x)
		{
			a = "Meta\\MetaObjects",
			b = new Point(0, 1),
			d = new float?(0f)
		});
		cm aspect = new cm(c5x, 10000, false);
		c5x.SetAspect<cm>(aspect);
		base.a8().Area.a(c5x);
		return c5x;
	}

	// Token: 0x04002BEB RID: 11243
	private bool a;

	// Token: 0x04002BEC RID: 11244
	private int b = 10;

	// Token: 0x04002BED RID: 11245
	private dth c;

	// Token: 0x04002BEE RID: 11246
	private string d;

	// Token: 0x04002BEF RID: 11247
	private string e;

	// Token: 0x04002BF0 RID: 11248
	private bjp f;

	// Token: 0x04002BF1 RID: 11249
	private double g;

	// Token: 0x04002BF2 RID: 11250
	private List<cze> h = new List<cze>();

	// Token: 0x04002BF3 RID: 11251
	private bool i = true;
}
