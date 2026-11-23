using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Ouroboros.Common;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;

// Token: 0x02001268 RID: 4712
[eiz("ASVDEA")]
[Serializable]
public sealed class aw : Aspect<c5x>, ISerializable, c98, bp1
{
	// Token: 0x0600661A RID: 26138 RVA: 0x002B6AFC File Offset: 0x002B4CFC
	private aw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetInt32("ASVDEA:P");
		this.d = A_0.GetDouble("ASVDEA:T");
		this.e = A_0.GetInt32("ASVDEA:TP");
	}

	// Token: 0x0600661B RID: 26139 RVA: 0x002B6B44 File Offset: 0x002B4D44
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ASVDEA:P", this.c);
		info.AddValue("ASVDEA:T", this.d);
		info.AddValue("ASVDEA:TP", this.e);
	}

	// Token: 0x0600661C RID: 26140 RVA: 0x002B6B8C File Offset: 0x002B4D8C
	public int f()
	{
		return this.c;
	}

	// Token: 0x0600661D RID: 26141 RVA: 0x002B6B94 File Offset: 0x002B4D94
	public void b(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600661E RID: 26142 RVA: 0x002B6BA0 File Offset: 0x002B4DA0
	public int d()
	{
		return this.e;
	}

	// Token: 0x0600661F RID: 26143 RVA: 0x002B6BA8 File Offset: 0x002B4DA8
	public void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006620 RID: 26144 RVA: 0x002B6BB4 File Offset: 0x002B4DB4
	public aw(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006621 RID: 26145 RVA: 0x002B6BC0 File Offset: 0x002B4DC0
	public void r7(eds A_0)
	{
		if (this.e != this.c)
		{
			if ((this.d += A_0.b.TotalMilliseconds) > (double)aw.a)
			{
				this.d -= (double)aw.a;
				int num;
				if (this.e < this.c)
				{
					num = -1;
				}
				else
				{
					num = 1;
				}
				if (num == 1)
				{
					this.c++;
					this.a();
					if (this.c == aw.b)
					{
						base.a8().c().a("xpbl_DeepStationVaultDoorClang");
					}
				}
				else
				{
					this.c--;
					this.a();
					if (this.c == 0)
					{
						base.a8().c().a("xpbl_DeepStationVaultDoorSlotting");
					}
				}
				this.b();
			}
			this.a(true);
			return;
		}
		this.d = 0.0;
		this.a(false);
	}

	// Token: 0x06006622 RID: 26146 RVA: 0x002B6CD0 File Offset: 0x002B4ED0
	public void b(bool A_0 = false)
	{
		this.e = aw.b;
		if (A_0)
		{
			this.c = aw.b;
			this.a(false);
			this.b();
			this.a();
		}
	}

	// Token: 0x06006623 RID: 26147 RVA: 0x002B6D04 File Offset: 0x002B4F04
	public void c(bool A_0 = false)
	{
		this.e = 0;
		if (A_0)
		{
			this.c = 0;
			this.a(false);
			this.b();
			this.a();
		}
	}

	// Token: 0x06006624 RID: 26148 RVA: 0x002B6D30 File Offset: 0x002B4F30
	public void e()
	{
		if (this.e == aw.b)
		{
			this.c(false);
			return;
		}
		this.b(false);
	}

	// Token: 0x06006625 RID: 26149 RVA: 0x002B6D54 File Offset: 0x002B4F54
	public void mx()
	{
		foreach (ak1 ak in base.a8().l)
		{
			foreach (b0b b0b in ak.c.Values)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.y8() == "abyssalVaultDoorMetaTile-Inner")
				{
					this.f = c5x;
				}
				else if (c5x.y8() == "abyssalVaultDoorMetaTile-Outer")
				{
					this.g = c5x;
				}
			}
		}
		this.b();
		this.a();
	}

	// Token: 0x06006626 RID: 26150 RVA: 0x002B6E40 File Offset: 0x002B5040
	public void my()
	{
	}

	// Token: 0x06006627 RID: 26151 RVA: 0x002B6E44 File Offset: 0x002B5044
	private void b()
	{
		cd0 aspect = base.a8().GetAspect<cd0>();
		if (aspect != null)
		{
			aspect.b = new Point(this.c, aspect.b.Y);
		}
	}

	// Token: 0x06006628 RID: 26152 RVA: 0x002B6E80 File Offset: 0x002B5080
	private void a(bool A_0)
	{
		if (A_0)
		{
			aru aru = base.a8().c();
			SoundState? soundState = aru.b("vaultDoorMovement");
			SoundState soundState2 = SoundState.Playing;
			if (!(soundState.GetValueOrDefault() == soundState2 & soundState != null))
			{
				aru.a("vaultDoorMovement", "xpbl_DeepStationVaultDoorMovement", 1f, c9z.a, true, false);
				return;
			}
		}
		else
		{
			base.a8().c().a("vaultDoorMovement", false);
		}
	}

	// Token: 0x06006629 RID: 26153 RVA: 0x002B6EF8 File Offset: 0x002B50F8
	private void a()
	{
		if (this.g != null)
		{
			if (this.c < 3)
			{
				this.g.TileFormationModifiers = new bjp(new byte[]
				{
					0,
					1,
					2,
					17
				});
			}
			else if (this.c < 2)
			{
				this.g.TileFormationModifiers = new bjp(new byte[]
				{
					1,
					2,
					17
				});
			}
			else
			{
				this.g.TileFormationModifiers = new bjp();
			}
		}
		if (this.f != null)
		{
			if (this.c < 5)
			{
				this.f.TileFormationModifiers = new bjp(new byte[]
				{
					0,
					1,
					2,
					17
				});
			}
			else if (this.c < 6)
			{
				this.f.TileFormationModifiers = new bjp(new byte[]
				{
					1,
					2,
					17
				});
			}
			else
			{
				this.f.TileFormationModifiers = new bjp();
			}
		}
		if (this.c >= 4)
		{
			base.a8().VisualPriority = -1;
		}
		else
		{
			base.a8().VisualPriority = 1;
		}
		base.a8().ah();
		if (this.c == 0)
		{
			Point point = base.a8().Location.a();
			clw clw = new clw();
			clw.a(new e6z(base.a8().Area));
			clw.a(false);
			if (base.a8().VisualDirection == HorizontalDirection.North || base.a8().VisualDirection == HorizontalDirection.South)
			{
				clw.a(Axis.Y);
			}
			else
			{
				clw.a(Axis.X);
			}
			if (base.a8().VisualDirection == HorizontalDirection.North)
			{
				clw.a().Add(new Point(point.X + 1, point.Y + 1));
				clw.a().Add(new Point(point.X + 1, point.Y + 1));
			}
			else if (base.a8().VisualDirection == HorizontalDirection.South)
			{
				clw.a().Add(point);
				clw.a().Add(new Point(point.X + 1, point.Y));
			}
			else if (base.a8().VisualDirection == HorizontalDirection.East)
			{
				clw.a().Add(point);
				clw.a().Add(new Point(point.X, point.Y + 1));
			}
			else if (base.a8().VisualDirection == HorizontalDirection.West)
			{
				clw.a().Add(new Point(point.X + 1, point.Y));
				clw.a().Add(new Point(point.X + 1, point.Y + 1));
			}
			clw.e().Add(base.a8().qe());
			base.a8().Zone.ActionManager.g9(clw, atp.a);
		}
	}

	// Token: 0x04002A6C RID: 10860
	private static readonly int a = 300;

	// Token: 0x04002A6D RID: 10861
	private static readonly int b = 7;

	// Token: 0x04002A6E RID: 10862
	private int c;

	// Token: 0x04002A6F RID: 10863
	private double d;

	// Token: 0x04002A70 RID: 10864
	private int e;

	// Token: 0x04002A71 RID: 10865
	[NonSerialized]
	private c5x f;

	// Token: 0x04002A72 RID: 10866
	[NonSerialized]
	private c5x g;
}
