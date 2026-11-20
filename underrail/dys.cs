using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common;

// Token: 0x02000B03 RID: 2819
[eiz("XPBLSRNGSJ")]
[Serializable]
public sealed class dys : cze, ISerializable
{
	// Token: 0x0600414A RID: 16714 RVA: 0x0018F378 File Offset: 0x0018D578
	private dys(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPBLSRNGSJ:O");
	}

	// Token: 0x0600414B RID: 16715 RVA: 0x0018F394 File Offset: 0x0018D594
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLSRNGSJ:O", this.a);
	}

	// Token: 0x0600414C RID: 16716 RVA: 0x0018F3B0 File Offset: 0x0018D5B0
	public bool a()
	{
		return this.a;
	}

	// Token: 0x0600414D RID: 16717 RVA: 0x0018F3B8 File Offset: 0x0018D5B8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600414E RID: 16718 RVA: 0x0018F3C4 File Offset: 0x0018D5C4
	public dys()
	{
	}

	// Token: 0x0600414F RID: 16719 RVA: 0x0018F3D0 File Offset: 0x0018D5D0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null && aud.Zone != null)
		{
			c5x c5x = new ar7(new Guid("22f4933c-3bde-4c47-8d0e-c3900e9354d0"), aud).ao() as c5x;
			bool flag = false;
			string text;
			string text2;
			if (this.a)
			{
				text = "northGateOpen";
				text2 = "northGateClosed";
			}
			else
			{
				text = "northGateClosed";
				text2 = "northGateOpen";
			}
			d60 d = aud.Zone.a();
			if (d != null)
			{
				clw clw = new clw();
				clw.a(new e6z(aud));
				clw.a(true);
				clw.a(Axis.Y);
				foreach (b0b b0b in d.ab4(new string[]
				{
					text
				}))
				{
					c5x c5x2 = (c5x)b0b;
					if (c5x != null && !flag && c5x2.aa)
					{
						flag = true;
						if (this.a)
						{
							c5x.c().a("Xpbl_RigNorthGateOpen");
						}
						else
						{
							c5x.c().a("Xpbl_RigNorthGateClose");
						}
					}
					c5x2.aa = false;
					c5x2.TileFormationModifiers = new bjp(new byte[]
					{
						0,
						1,
						2
					});
					clw.e().Add(c5x2.qe());
					foreach (ak1 ak in c5x2.l)
					{
						if (!clw.a().Contains(ak.Location))
						{
							clw.a().Add(ak.Location);
						}
					}
				}
				foreach (b0b b0b2 in d.ab4(new string[]
				{
					text2
				}))
				{
					c5x c5x3 = (c5x)b0b2;
					c5x3.aa = true;
					c5x3.TileFormationModifiers.c();
					c5x3.z();
					clw.e().Add(c5x3.qe());
				}
				aud.Zone.ActionManager.g9(clw, atp.a);
			}
		}
	}

	// Token: 0x04001C14 RID: 7188
	private new bool a;
}
