using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02001311 RID: 4881
[eiz("CEA4")]
[Serializable]
public class alv : Aspect<c5x>, b0w, bp1, bdi, ISerializable, a8j
{
	// Token: 0x06006D66 RID: 28006 RVA: 0x002DBB20 File Offset: 0x002D9D20
	protected alv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<cd0>("CEA4:C", ref this.a, A_0);
			return;
		}
		di7.ReadList<cd0>("Components", ref this.a, A_0);
	}

	// Token: 0x06006D67 RID: 28007 RVA: 0x002DBB70 File Offset: 0x002D9D70
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cd0>("CEA4:C", this.a, info);
	}

	// Token: 0x06006D68 RID: 28008 RVA: 0x002DBB8C File Offset: 0x002D9D8C
	public alv(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x06006D69 RID: 28009 RVA: 0x002DBBA0 File Offset: 0x002D9DA0
	public Point CurrentFrame
	{
		get
		{
			if (this.a != null && this.a.Count > 0)
			{
				return this.a[0].b;
			}
			return Point.Zero;
		}
	}

	// Token: 0x06006D6A RID: 28010 RVA: 0x002DBBD8 File Offset: 0x002D9DD8
	public void a(cd0 A_0)
	{
		this.a.Add(A_0);
		bp1 bp = A_0 as bp1;
		if (bp != null)
		{
			bp.mx();
		}
	}

	// Token: 0x06006D6B RID: 28011 RVA: 0x002DBC04 File Offset: 0x002D9E04
	public void a(int A_0, cd0 A_1)
	{
		this.a.Insert(A_0, A_1);
		bp1 bp = A_1 as bp1;
		if (bp != null)
		{
			bp.mx();
		}
	}

	// Token: 0x06006D6C RID: 28012 RVA: 0x002DBC34 File Offset: 0x002D9E34
	public bool b(cd0 A_0)
	{
		bool flag = this.a.Remove(A_0);
		if (flag)
		{
			bp1 bp = A_0 as bp1;
			if (bp != null)
			{
				bp.my();
			}
		}
		return flag;
	}

	// Token: 0x06006D6D RID: 28013 RVA: 0x002DBC68 File Offset: 0x002D9E68
	public bool a(int A_0)
	{
		cd0 cd = null;
		if (this.a.Count > A_0)
		{
			cd = this.a[A_0];
			this.a.RemoveAt(A_0);
		}
		if (cd != null)
		{
			bp1 bp = cd as bp1;
			if (bp != null)
			{
				bp.my();
			}
		}
		return cd != null;
	}

	// Token: 0x06006D6E RID: 28014 RVA: 0x002DBCC0 File Offset: 0x002D9EC0
	public virtual void v2()
	{
		if (this.a != null)
		{
			foreach (cd0 cd in this.a)
			{
				cd.v2();
			}
		}
	}

	// Token: 0x06006D6F RID: 28015 RVA: 0x002DBD24 File Offset: 0x002D9F24
	public virtual void v3()
	{
		if (this.a != null)
		{
			foreach (cd0 cd in this.a)
			{
				cd.v3();
			}
		}
	}

	// Token: 0x06006D70 RID: 28016 RVA: 0x002DBD88 File Offset: 0x002D9F88
	public void p9(b0b A_0)
	{
		czh.a(A_0, "entity");
		if (this.a != null)
		{
			alv aspect = A_0.GetAspect<alv>();
			if (aspect != null && aspect.a.Count == this.a.Count)
			{
				for (int i = 0; i < this.a.Count; i++)
				{
					aspect.a[i].b = this.a[i].b;
				}
			}
		}
	}

	// Token: 0x06006D71 RID: 28017 RVA: 0x002DBE10 File Offset: 0x002DA010
	public void qa()
	{
		if (this.a != null)
		{
			foreach (cd0 cd in this.a)
			{
				cd.qa();
			}
		}
	}

	// Token: 0x06006D72 RID: 28018 RVA: 0x002DBE74 File Offset: 0x002DA074
	public void mx()
	{
		base.a8().g |= e2b.e;
		if (this.a != null)
		{
			foreach (cd0 cd in this.a)
			{
				bp1 bp = cd as bp1;
				if (bp != null)
				{
					bp.mx();
				}
			}
		}
		base.a8().a(new EventHandler<c1>(this.a));
	}

	// Token: 0x06006D73 RID: 28019 RVA: 0x002DBF10 File Offset: 0x002DA110
	public void my()
	{
		base.a8().g &= ~e2b.e;
		if (this.a != null)
		{
			foreach (cd0 cd in this.a)
			{
				bp1 bp = cd as bp1;
				if (bp != null)
				{
					bp.my();
				}
			}
		}
		base.a8().b(new EventHandler<c1>(this.a));
	}

	// Token: 0x06006D74 RID: 28020 RVA: 0x002DBFAC File Offset: 0x002DA1AC
	public void qb(int A_0, bool A_1 = false)
	{
		if (this.a != null)
		{
			foreach (cd0 cd in this.a)
			{
				cd.qb(A_0, A_1);
			}
		}
	}

	// Token: 0x06006D75 RID: 28021 RVA: 0x002DC010 File Offset: 0x002DA210
	public void qc(int A_0)
	{
		if (this.a != null)
		{
			foreach (cd0 cd in this.a)
			{
				cd.qc(A_0);
			}
		}
	}

	// Token: 0x06006D76 RID: 28022 RVA: 0x002DC074 File Offset: 0x002DA274
	public void qd(cuw A_0)
	{
		base.Container = A_0;
		if (this.a != null && this.a.Count > 0)
		{
			foreach (cd0 cd in this.a)
			{
				cd.Container = A_0;
			}
		}
	}

	// Token: 0x06006D77 RID: 28023 RVA: 0x002DC0F0 File Offset: 0x002DA2F0
	[dcc("CEA4:mAVDC")]
	private void a(object A_0, c1 A_1)
	{
		if (this.a != null && this.a.Count > 0)
		{
			foreach (cd0 cd in this.a)
			{
				avp avp = cd as avp;
				if (avp != null)
				{
					avp.o5();
				}
			}
		}
	}

	// Token: 0x04002CC8 RID: 11464
	public List<cd0> a = new List<cd0>();
}
