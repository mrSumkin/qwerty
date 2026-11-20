using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200104E RID: 4174
[eiz("SEJ")]
[Serializable]
public class ezd : cze, ISerializable
{
	// Token: 0x0600567D RID: 22141 RVA: 0x0025F40C File Offset: 0x0025D60C
	protected ezd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (bt4)A_0.GetValue("SEJ:L", typeof(bt4));
			this.b = A_0.GetString("SEJ:BP");
			this.d = (HorizontalDirection?)A_0.GetValue("SEJ:D", typeof(HorizontalDirection?));
			this.e = (Guid?)A_0.GetValue("SEJ:I", typeof(Guid?));
			this.g = A_0.GetString("SEJ:N");
			if (ell.a() >= 33)
			{
				this.c = A_0.GetString("SEJ:PP");
			}
			if (ell.a() >= 348)
			{
				this.h = A_0.GetBoolean("SEJ:DP");
			}
			if (ell.a() >= 484)
			{
				this.i = (A_0.GetValue("SEJ:CS", typeof(CharacterState?)) as CharacterState?);
				this.j = (A_0.GetValue("SEJ:CF", typeof(int?)) as int?);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(ezd))
			{
				this.a = (bt4)A_0.GetValue("_Location", typeof(bt4));
				this.b = A_0.GetString("_BlueprintPath");
				this.d = (HorizontalDirection?)A_0.GetValue("_Direction", typeof(HorizontalDirection?));
				this.e = (Guid?)A_0.GetValue("_Id", typeof(Guid?));
				this.g = A_0.GetString("_Name");
				return;
			}
			this.a = (bt4)A_0.GetValue("SpawnEntityJob+_Location", typeof(bt4));
			this.b = A_0.GetString("SpawnEntityJob+_BlueprintPath");
			this.d = (HorizontalDirection?)A_0.GetValue("SpawnEntityJob+_Direction", typeof(HorizontalDirection?));
			this.e = (Guid?)A_0.GetValue("SpawnEntityJob+_Id", typeof(Guid?));
			this.g = A_0.GetString("SpawnEntityJob+_Name");
		}
	}

	// Token: 0x0600567E RID: 22142 RVA: 0x0025F67C File Offset: 0x0025D87C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEJ:L", this.a);
		info.AddValue("SEJ:BP", this.b);
		info.AddValue("SEJ:PP", this.c);
		info.AddValue("SEJ:D", this.d);
		info.AddValue("SEJ:I", this.e);
		info.AddValue("SEJ:N", this.g);
		info.AddValue("SEJ:DP", this.h);
		info.AddValue("SEJ:CS", this.i);
		info.AddValue("SEJ:CF", this.j);
	}

	// Token: 0x0600567F RID: 22143 RVA: 0x0025F740 File Offset: 0x0025D940
	public Guid? e()
	{
		return this.e;
	}

	// Token: 0x06005680 RID: 22144 RVA: 0x0025F748 File Offset: 0x0025D948
	public void a(Guid? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005681 RID: 22145 RVA: 0x0025F754 File Offset: 0x0025D954
	public bt4 h()
	{
		return this.a;
	}

	// Token: 0x06005682 RID: 22146 RVA: 0x0025F75C File Offset: 0x0025D95C
	public void a(bt4 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005683 RID: 22147 RVA: 0x0025F768 File Offset: 0x0025D968
	public string i()
	{
		return this.b;
	}

	// Token: 0x06005684 RID: 22148 RVA: 0x0025F770 File Offset: 0x0025D970
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005685 RID: 22149 RVA: 0x0025F77C File Offset: 0x0025D97C
	public HorizontalDirection? b()
	{
		return this.d;
	}

	// Token: 0x06005686 RID: 22150 RVA: 0x0025F784 File Offset: 0x0025D984
	public void a(HorizontalDirection? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005687 RID: 22151 RVA: 0x0025F790 File Offset: 0x0025D990
	public ar7 f()
	{
		return this.f;
	}

	// Token: 0x06005688 RID: 22152 RVA: 0x0025F798 File Offset: 0x0025D998
	public string c()
	{
		return this.g;
	}

	// Token: 0x06005689 RID: 22153 RVA: 0x0025F7A0 File Offset: 0x0025D9A0
	public void c(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600568A RID: 22154 RVA: 0x0025F7AC File Offset: 0x0025D9AC
	public string a()
	{
		return this.c;
	}

	// Token: 0x0600568B RID: 22155 RVA: 0x0025F7B4 File Offset: 0x0025D9B4
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600568C RID: 22156 RVA: 0x0025F7C0 File Offset: 0x0025D9C0
	public bool d()
	{
		return this.h;
	}

	// Token: 0x0600568D RID: 22157 RVA: 0x0025F7C8 File Offset: 0x0025D9C8
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600568E RID: 22158 RVA: 0x0025F7D4 File Offset: 0x0025D9D4
	public CharacterState? j()
	{
		return this.i;
	}

	// Token: 0x0600568F RID: 22159 RVA: 0x0025F7DC File Offset: 0x0025D9DC
	public void a(CharacterState? A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06005690 RID: 22160 RVA: 0x0025F7E8 File Offset: 0x0025D9E8
	public int? g()
	{
		return this.j;
	}

	// Token: 0x06005691 RID: 22161 RVA: 0x0025F7F0 File Offset: 0x0025D9F0
	public void a(int? A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06005692 RID: 22162 RVA: 0x0025F7FC File Offset: 0x0025D9FC
	public ezd()
	{
	}

	// Token: 0x06005693 RID: 22163 RVA: 0x0025F820 File Offset: 0x0025DA20
	public ezd(string A_0, bt4 A_1, HorizontalDirection? A_2 = null, Guid? A_3 = null, CharacterState? A_4 = null, int? A_5 = null, string A_6 = null)
	{
		this.b = A_0;
		this.a = A_1;
		this.d = A_2;
		this.e = A_3;
		this.i = A_4;
		this.j = A_5;
		this.c = A_6;
	}

	// Token: 0x06005694 RID: 22164 RVA: 0x0025F880 File Offset: 0x0025DA80
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a.c())
		{
			d6j serviceOrThrow = bpo.GetServiceOrThrow<d6j>();
			cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow2.aqw() != null)
			{
				c5x c5x = null;
				if (!string.IsNullOrWhiteSpace(this.c))
				{
					c5x = (serviceOrThrow.dv().b(this.c) as c5x);
					if (c5x != null && this.e != null)
					{
						c5x.i(this.e.Value);
					}
				}
				else if (!string.IsNullOrWhiteSpace(this.b))
				{
					c5k c5k = serviceOrThrow.dv().a(this.b);
					if (c5k != null)
					{
						c5x = (c5k.a(this.e, false) as c5x);
					}
				}
				if (c5x != null)
				{
					c5x.Layer = aju.x;
					if (c5x != null)
					{
						aud aud;
						Vector3 vector;
						HorizontalDirection a_;
						this.a.a(serviceOrThrow2.aqw(), out aud, out vector, out a_);
						if (aud != null)
						{
							if (this.d != null)
							{
								c5x.VisualDirection = this.d.Value;
							}
							else
							{
								c5x.VisualDirection = a_;
							}
							if (!string.IsNullOrEmpty(this.g))
							{
								c5x.q(this.g);
							}
							c5x.Location = vector;
							if (this.h)
							{
								c5x.Location = a0l.a(aud, vector, null, null);
							}
							amc aspect = c5x.GetAspect<amc>();
							if (aspect != null)
							{
								if (this.i != null)
								{
									aspect.ap = this.i;
								}
								if (this.j != null)
								{
									aspect.aq = this.j;
								}
							}
							else if (this.j != null)
							{
								c5x.o.b.b = new Point(this.j.Value, 0);
							}
							aud.a(c5x);
							this.f.a(c5x);
						}
					}
				}
			}
		}
	}

	// Token: 0x04002313 RID: 8979
	private new bt4 a = new bt4();

	// Token: 0x04002314 RID: 8980
	private string b;

	// Token: 0x04002315 RID: 8981
	private string c;

	// Token: 0x04002316 RID: 8982
	private HorizontalDirection? d;

	// Token: 0x04002317 RID: 8983
	private Guid? e;

	// Token: 0x04002318 RID: 8984
	[NonSerialized]
	private ar7 f = new ar7();

	// Token: 0x04002319 RID: 8985
	private string g;

	// Token: 0x0400231A RID: 8986
	private bool h;

	// Token: 0x0400231B RID: 8987
	private CharacterState? i;

	// Token: 0x0400231C RID: 8988
	private int? j;
}
