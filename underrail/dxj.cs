using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000F6D RID: 3949
[eiz("BAGICEA")]
[a(typeof(dy8))]
[Serializable]
public sealed class dxj : dy8
{
	// Token: 0x06005020 RID: 20512 RVA: 0x0023ED40 File Offset: 0x0023CF40
	private dxj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("BAGICEA:G", ref this.a, A_0);
		di7.ReadList<string>("BAGICEA:B", ref this.b, A_0);
		this.c = A_0.GetInt32("BAGICEA:M");
		this.d = A_0.GetString("BAGICEA:R");
	}

	// Token: 0x06005021 RID: 20513 RVA: 0x0023EDB0 File Offset: 0x0023CFB0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("BAGICEA:G", this.a, info);
		di7.WriteList<string>("BAGICEA:B", this.b, info);
		info.AddValue("BAGICEA:M", this.c);
		info.AddValue("BAGICEA:R", this.d);
	}

	// Token: 0x06005022 RID: 20514 RVA: 0x0023EE0C File Offset: 0x0023D00C
	public List<Guid> a()
	{
		return this.a;
	}

	// Token: 0x06005023 RID: 20515 RVA: 0x0023EE14 File Offset: 0x0023D014
	public void a(List<Guid> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005024 RID: 20516 RVA: 0x0023EE20 File Offset: 0x0023D020
	public List<string> b()
	{
		return this.b;
	}

	// Token: 0x06005025 RID: 20517 RVA: 0x0023EE28 File Offset: 0x0023D028
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005026 RID: 20518 RVA: 0x0023EE34 File Offset: 0x0023D034
	public int e()
	{
		return this.c;
	}

	// Token: 0x06005027 RID: 20519 RVA: 0x0023EE3C File Offset: 0x0023D03C
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005028 RID: 20520 RVA: 0x0023EE48 File Offset: 0x0023D048
	public string d()
	{
		return this.d;
	}

	// Token: 0x06005029 RID: 20521 RVA: 0x0023EE50 File Offset: 0x0023D050
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600502A RID: 20522 RVA: 0x0023EE5C File Offset: 0x0023D05C
	public dxj(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600502B RID: 20523 RVA: 0x0023EE7C File Offset: 0x0023D07C
	protected override void o2()
	{
		foreach (Guid a_ in this.a)
		{
			dxv dxv = new EntityAspectReference<dxv, dxv>(base.a8().Area, a_).ao();
			if (dxv != null)
			{
				dxv.a(true);
			}
		}
	}

	// Token: 0x0600502C RID: 20524 RVA: 0x0023EEF4 File Offset: 0x0023D0F4
	protected override void o3()
	{
		foreach (Guid a_ in this.a)
		{
			dxv dxv = new EntityAspectReference<dxv, dxv>(base.a8().Area, a_).ao();
			if (dxv != null)
			{
				dxv.a(false);
			}
		}
		d60 addon = base.a8().Zone.GetAddon<d60>();
		if (addon != null)
		{
			foreach (b0b b0b in addon.ab4(new string[]
			{
				this.d
			}))
			{
				((c5x)b0b).h.b.a(null, false);
			}
		}
	}

	// Token: 0x0600502D RID: 20525 RVA: 0x0023EFE8 File Offset: 0x0023D1E8
	protected override void o4()
	{
		if (!string.IsNullOrEmpty(this.d))
		{
			d60 addon = base.a8().Zone.GetAddon<d60>();
			if (addon != null)
			{
				List<b0b> list = addon.ab4(new string[]
				{
					this.d
				});
				if (list.Count < this.c)
				{
					int num = this.c - list.Count;
					foreach (string a_ in this.b)
					{
						if (num == 0)
						{
							break;
						}
						csd csd = base.a8().Zone.g(a_);
						if (csd != null && csd.Tile != null && csd.Tile != null && !aw1.a(null, csd.Tile, false, null))
						{
							c5x c5x = vq.a("creatures\\machines\\SuicideBot", csd, false);
							if (c5x != null)
							{
								c5x.SetAspect<e3l>(new e3l(c5x)
								{
									a = 
									{
										this.d
									}
								});
								if (c5x.h.b != null)
								{
									c5x.h.b.aa().FactionId = asp.e1;
								}
								if (c5x.t.b != null)
								{
									c5x.t.b.y6()[ddq.bn] = 20;
									c5x.t.b.y6()[ddq.bo] = 5;
								}
								num--;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x040020AC RID: 8364
	private List<Guid> a = new List<Guid>();

	// Token: 0x040020AD RID: 8365
	private List<string> b = new List<string>();

	// Token: 0x040020AE RID: 8366
	private new int c;

	// Token: 0x040020AF RID: 8367
	private string d;
}
