using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200126F RID: 4719
[a(typeof(bim))]
[eiz("TDEA")]
[Serializable]
public sealed class c2r : bim, ISerializable
{
	// Token: 0x0600665C RID: 26204 RVA: 0x002B83C4 File Offset: 0x002B65C4
	private c2r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("TDEA:O");
		this.b = A_0.GetString("TDEA:D");
		this.c = A_0.GetString("TDEA:L");
	}

	// Token: 0x0600665D RID: 26205 RVA: 0x002B840C File Offset: 0x002B660C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TDEA:O", this.a);
		info.AddValue("TDEA:D", this.b);
		info.AddValue("TDEA:L", this.c);
	}

	// Token: 0x0600665E RID: 26206 RVA: 0x002B8454 File Offset: 0x002B6654
	public bool b()
	{
		return this.a;
	}

	// Token: 0x0600665F RID: 26207 RVA: 0x002B845C File Offset: 0x002B665C
	public void a(bool A_0)
	{
		this.a = A_0;
		this.a();
	}

	// Token: 0x06006660 RID: 26208 RVA: 0x002B846C File Offset: 0x002B666C
	public string e()
	{
		return this.b;
	}

	// Token: 0x06006661 RID: 26209 RVA: 0x002B8474 File Offset: 0x002B6674
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006662 RID: 26210 RVA: 0x002B8480 File Offset: 0x002B6680
	public string d()
	{
		return this.c;
	}

	// Token: 0x06006663 RID: 26211 RVA: 0x002B8488 File Offset: 0x002B6688
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006664 RID: 26212 RVA: 0x002B8494 File Offset: 0x002B6694
	public c2r(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006665 RID: 26213 RVA: 0x002B84A0 File Offset: 0x002B66A0
	public override avd[] jz()
	{
		if (this.a)
		{
			List<avd> list = new List<avd>();
			if (this.a)
			{
				list.Add(new avd("go", "Abilities.70", "Спуститься", "Спуститься в люк."));
				list.Add(new avd("close", "Abilities.71", "Закрыть", "Закрыть люк."));
			}
			else
			{
				list.Add(new avd("open", "Abilities.71", "Открыть", "Открыть люк."));
			}
			return list.ToArray();
		}
		return null;
	}

	// Token: 0x06006666 RID: 26214 RVA: 0x002B8534 File Offset: 0x002B6734
	protected override void mz(c5x A_0, string A_1 = null)
	{
		string text;
		if (A_1 == null)
		{
			if (this.a)
			{
				text = "go";
			}
			else
			{
				text = "open";
			}
		}
		else
		{
			text = A_1;
		}
		if (text == "close")
		{
			if (this.a)
			{
				base.a8().c().a("open_close", false);
				base.a8().c().a("open_close", "HollowEarthPointBunkerClose", 1f, c9z.a, false, false);
				this.a = false;
				base.a8().TileFormationModifiers.c();
				base.a8().z();
				this.a();
				return;
			}
		}
		else if (text == "open")
		{
			if (!this.a)
			{
				ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
				if (ak != null && !aw1.a(null, ak, false, null))
				{
					base.a8().c().a("open_close", false);
					base.a8().c().a("open_close", "HollowEarthPointBunkerOpen", 1f, c9z.a, false, false);
					this.a = true;
					base.a8().TileFormationModifiers.s3(1);
					base.a8().z();
					this.a();
					return;
				}
				base.a8().c().a("open_close", false);
				base.a8().c().a("open_close", "MetalTrapDoorOpenFail", 1f, c9z.a, false, false);
				bmj.a(base.a8(), new d53("Заблокировано", adi.l, null, true));
				return;
			}
		}
		else if (text == "go" && A_0 != null && !string.IsNullOrEmpty(this.b))
		{
			if (!string.IsNullOrEmpty(this.c))
			{
				if (A_0 != null)
				{
					A_0.c().a("LadderClimb");
				}
				a0l.a(new c2w(this.c, this.b));
				return;
			}
			csd csd = base.a8().Zone.g(this.b);
			if (csd != null)
			{
				if (csd.Tile != null && csd.Tile.c.Count > 0)
				{
					c5x c5x = Enumerable.FirstOrDefault<b0b>(csd.Tile.c.Keys) as c5x;
					if (c5x != null)
					{
						c5x.c().a("LadderClimb");
					}
				}
				a0l.a(A_0, this.b, true);
			}
		}
	}

	// Token: 0x06006667 RID: 26215 RVA: 0x002B87C4 File Offset: 0x002B69C4
	private void a()
	{
		try
		{
			if (this.a)
			{
				base.a8().o.b.b = new Point(1, base.a8().o.b.b.Y);
			}
			else
			{
				base.a8().o.b.b = new Point(0, base.a8().o.b.b.Y);
			}
		}
		catch
		{
		}
	}

	// Token: 0x04002A7B RID: 10875
	private new bool a;

	// Token: 0x04002A7C RID: 10876
	private string b;

	// Token: 0x04002A7D RID: 10877
	private string c;
}
