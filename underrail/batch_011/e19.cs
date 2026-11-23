using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200133E RID: 4926
public abstract class e19 : bb0
{
	// Token: 0x06006FA4 RID: 28580 RVA: 0x002ED598 File Offset: 0x002EB798
	public virtual bool a()
	{
		return true;
	}

	// Token: 0x06006FA5 RID: 28581 RVA: 0x002ED59C File Offset: 0x002EB79C
	public virtual int b()
	{
		return 150;
	}

	// Token: 0x06006FA6 RID: 28582 RVA: 0x002ED5A8 File Offset: 0x002EB7A8
	public virtual void b0(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
		string[] array = this.ic();
		if (array != null && array.Length != 0)
		{
			string str = this.a(A_0, A_1, A_2, A_3) ?? "";
			string text = this.a(A_3);
			foreach (string str2 in array)
			{
				string text2 = "Firing\\" + str + str2;
				if (!string.IsNullOrEmpty(text))
				{
					text2 = text2 + "_" + text;
				}
				c5x a_ = A_0.a8();
				string a_2 = text2;
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = false;
				bool a_5 = true;
				float? a_6 = dz6.b();
				c5x c5x = boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
				if (c5x != null)
				{
					c5x.VisualDirection = A_0.a8().VisualDirection;
					if (c5x.VisualDirection == HorizontalDirection.North || c5x.VisualDirection == HorizontalDirection.Northwest || c5x.VisualDirection == HorizontalDirection.West)
					{
						c5x.VisualPriority *= -1;
					}
					if (this.a())
					{
						c5x.ad = new Color?(Color.White);
					}
				}
			}
			ah7 ah = this.asp(A_0.am(), A_3);
			if (ah != null)
			{
				ejt ejt = ah.g();
				c5x c5x2 = new c5x();
				c5x2.Layer = aju.x;
				c5x2.Location = A_0.a8().Location;
				A_0.a8().Area.a(c5x2);
				ejt.be(c5x2);
				qy qy = new qy();
				qy.ad().Add(new bm3(dz6.b(this.b())));
				List<auv> list = qy.ad();
				c7 c = new c7(c5x2, false, false, true, false);
				c.a(true);
				list.Add(c);
				A_0.a8().Zone.ActionManager.g9(qy, atp.a);
			}
		}
	}

	// Token: 0x06006FA7 RID: 28583
	protected abstract string[] ic();

	// Token: 0x06006FA8 RID: 28584 RVA: 0x002ED79C File Offset: 0x002EB99C
	protected virtual string a(AmmoType A_0)
	{
		return null;
	}

	// Token: 0x06006FA9 RID: 28585 RVA: 0x002ED7A0 File Offset: 0x002EB9A0
	protected virtual ah7 asp(string A_0, AmmoType A_1)
	{
		return null;
	}

	// Token: 0x06006FAA RID: 28586 RVA: 0x002ED7A4 File Offset: 0x002EB9A4
	protected virtual string a(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
		if (A_0 != null && A_0.am() == bln.b)
		{
			return "f_";
		}
		return null;
	}
}
