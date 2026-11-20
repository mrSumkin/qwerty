using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020007C5 RID: 1989
[a(typeof(bim))]
[eiz("HEPEA")]
[Serializable]
public sealed class df9 : bim, ISerializable
{
	// Token: 0x060031CB RID: 12747 RVA: 0x00130CE4 File Offset: 0x0012EEE4
	private df9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("HEPEA:O");
		this.b = A_0.GetString("HEPEA:D");
	}

	// Token: 0x060031CC RID: 12748 RVA: 0x00130D10 File Offset: 0x0012EF10
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HEPEA:O", this.a);
		info.AddValue("HEPEA:D", this.b);
	}

	// Token: 0x060031CD RID: 12749 RVA: 0x00130D3C File Offset: 0x0012EF3C
	public bool b()
	{
		return this.a;
	}

	// Token: 0x060031CE RID: 12750 RVA: 0x00130D44 File Offset: 0x0012EF44
	public void a(bool A_0)
	{
		this.a = A_0;
		this.a();
	}

	// Token: 0x060031CF RID: 12751 RVA: 0x00130D54 File Offset: 0x0012EF54
	public string d()
	{
		return this.b;
	}

	// Token: 0x060031D0 RID: 12752 RVA: 0x00130D5C File Offset: 0x0012EF5C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060031D1 RID: 12753 RVA: 0x00130D68 File Offset: 0x0012EF68
	public df9(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060031D2 RID: 12754 RVA: 0x00130D74 File Offset: 0x0012EF74
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

	// Token: 0x060031D3 RID: 12755 RVA: 0x00130E08 File Offset: 0x0012F008
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
				bmj.a(base.a8(), new d53("Заблокировано", adi.l, null, true));
				return;
			}
		}
		else if (text == "go" && A_0 != null)
		{
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

	// Token: 0x060031D4 RID: 12756 RVA: 0x00131010 File Offset: 0x0012F210
	private void a()
	{
		try
		{
			if (this.a)
			{
				base.a8().o.b.b = new Point(1, 0);
			}
			else
			{
				base.a8().o.b.b = new Point(0, 0);
			}
		}
		catch
		{
		}
	}

	// Token: 0x04001AC2 RID: 6850
	private new bool a;

	// Token: 0x04001AC3 RID: 6851
	private string b;
}
