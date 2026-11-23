using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000692 RID: 1682
[eiz("CP")]
[Serializable]
public class av : cnm, ISerializable
{
	// Token: 0x06002BB1 RID: 11185 RVA: 0x000FC8D4 File Offset: 0x000FAAD4
	protected av(SerializationInfo A_0, StreamingContext A_1)
	{
		this.d = A_0.GetBoolean("CP:MR");
		this.e = A_0.GetDateTime("CP:VT");
		this.f = (aia)A_0.GetValue("CP:CR", typeof(aia));
		this.g = (TypedObjectReference<efk>)A_0.GetValue("CP:IR", typeof(TypedObjectReference<efk>));
		this.h = (a3s)A_0.GetValue("CP:MR1", typeof(a3s));
		if (ell.a() >= 56)
		{
			this.i = A_0.GetString("CP:I");
		}
	}

	// Token: 0x06002BB2 RID: 11186 RVA: 0x000FC988 File Offset: 0x000FAB88
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CP:MR", this.d);
		info.AddValue("CP:VT", this.e);
		info.AddValue("CP:CR", this.f);
		info.AddValue("CP:IR", this.g);
		info.AddValue("CP:MR1", this.h);
		info.AddValue("CP:I", this.i);
	}

	// Token: 0x06002BB3 RID: 11187 RVA: 0x000FC9FC File Offset: 0x000FABFC
	public TypedObjectReference<efk> s()
	{
		return this.g;
	}

	// Token: 0x06002BB4 RID: 11188 RVA: 0x000FCA04 File Offset: 0x000FAC04
	public bool t()
	{
		this.a();
		return this.d;
	}

	// Token: 0x06002BB5 RID: 11189 RVA: 0x000FCA14 File Offset: 0x000FAC14
	public virtual bool yw()
	{
		return this.t() && this.r() && this.x() >= 1f;
	}

	// Token: 0x06002BB6 RID: 11190 RVA: 0x000FCA40 File Offset: 0x000FAC40
	public bool w()
	{
		return !this.p().RequiresMedium || this.b9() != null;
	}

	// Token: 0x06002BB7 RID: 11191 RVA: 0x000FCA60 File Offset: 0x000FAC60
	public float x()
	{
		ip ip = this.p().v(this);
		if (ip != null && ip.b != 0.0)
		{
			return (float)(1.0 - ip.a / ip.b);
		}
		return 1f;
	}

	// Token: 0x06002BB8 RID: 11192 RVA: 0x000FCAB4 File Offset: 0x000FACB4
	public ip n()
	{
		return this.p().v(this);
	}

	// Token: 0x06002BB9 RID: 11193 RVA: 0x000FCAC4 File Offset: 0x000FACC4
	public bool r()
	{
		return this.p().hm(this);
	}

	// Token: 0x06002BBA RID: 11194 RVA: 0x000FCAD4 File Offset: 0x000FACD4
	public bool o()
	{
		return this.p().cu(this);
	}

	// Token: 0x06002BBB RID: 11195 RVA: 0x000FCAE4 File Offset: 0x000FACE4
	public dsk v()
	{
		return this.p().cv(this);
	}

	// Token: 0x06002BBC RID: 11196 RVA: 0x000FCAF4 File Offset: 0x000FACF4
	public c3n p()
	{
		return this.f.Value;
	}

	// Token: 0x06002BBD RID: 11197 RVA: 0x000FCB04 File Offset: 0x000FAD04
	public efk b8()
	{
		return this.g.ao();
	}

	// Token: 0x06002BBE RID: 11198 RVA: 0x000FCB14 File Offset: 0x000FAD14
	public object b9()
	{
		if (this.h != null)
		{
			return this.h.afk();
		}
		return null;
	}

	// Token: 0x06002BBF RID: 11199 RVA: 0x000FCB30 File Offset: 0x000FAD30
	public object ca()
	{
		return null;
	}

	// Token: 0x06002BC0 RID: 11200 RVA: 0x000FCB34 File Offset: 0x000FAD34
	public bool q()
	{
		return this.p().v0(this);
	}

	// Token: 0x06002BC1 RID: 11201 RVA: 0x000FCB44 File Offset: 0x000FAD44
	public string u()
	{
		return this.p().bo(this);
	}

	// Token: 0x06002BC2 RID: 11202 RVA: 0x000FCB54 File Offset: 0x000FAD54
	public string y()
	{
		return this.p().bm(this);
	}

	// Token: 0x06002BC3 RID: 11203 RVA: 0x000FCB64 File Offset: 0x000FAD64
	public int d(object A_0)
	{
		if (A_0 != null)
		{
			return this.p().afh(new eoj(this.b8(), this.b9(), A_0));
		}
		return this.p().afh(this);
	}

	// Token: 0x06002BC4 RID: 11204 RVA: 0x000FCBA4 File Offset: 0x000FADA4
	internal av(TypedObjectReference<efk> A_0, c3n A_1, object A_2)
	{
		czh.a(A_0, "invokerReference");
		czh.a(A_1, "capability");
		this.g = A_0;
		this.f = new aia(A_1);
		coh coh = A_2 as coh;
		if (coh != null)
		{
			this.h = new cuj(this.g, coh);
		}
		this.b();
	}

	// Token: 0x06002BC5 RID: 11205 RVA: 0x000FCC08 File Offset: 0x000FAE08
	public virtual av xh()
	{
		return new av(this.g, this.p(), this.b9());
	}

	// Token: 0x06002BC6 RID: 11206 RVA: 0x000FCC24 File Offset: 0x000FAE24
	public void a(bool A_0 = false)
	{
		coh coh = this.b9() as coh;
		if (coh != null && coh.Definition != null && (A_0 || coh.Definition.bg()))
		{
			if (coh.Stacks > 1)
			{
				coh coh2 = coh;
				int num = coh2.Stacks;
				coh2.Stacks = num - 1;
				this.b8().bl();
				return;
			}
			if (this.b8() != null)
			{
				this.b8().a(coh);
			}
		}
	}

	// Token: 0x06002BC7 RID: 11207 RVA: 0x000FCCA4 File Offset: 0x000FAEA4
	public IList<cfd> a(v5 A_0)
	{
		return this.p().bq(this, A_0);
	}

	// Token: 0x06002BC8 RID: 11208 RVA: 0x000FCCB4 File Offset: 0x000FAEB4
	public IList<cfd> b(v5 A_0)
	{
		return this.p().p5(this, A_0);
	}

	// Token: 0x06002BC9 RID: 11209 RVA: 0x000FCCC8 File Offset: 0x000FAEC8
	private void b()
	{
		this.d = true;
		using (List<brl>.Enumerator enumerator = this.p().j0().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.oh(this.b8()))
				{
					this.d = false;
					break;
				}
			}
		}
	}

	// Token: 0x06002BCA RID: 11210 RVA: 0x000FCD44 File Offset: 0x000FAF44
	private void a()
	{
		if (DateTime.Now >= this.e || this.e - DateTime.Now > TimeSpan.FromSeconds(1.0))
		{
			this.b();
			this.e = DateTime.Now + TimeSpan.FromMilliseconds((double)(100 + av.c.Next(200)));
		}
	}

	// Token: 0x040018F8 RID: 6392
	private const int a = 100;

	// Token: 0x040018F9 RID: 6393
	private const int b = 200;

	// Token: 0x040018FA RID: 6394
	private static Random c = new Random();

	// Token: 0x040018FB RID: 6395
	private bool d;

	// Token: 0x040018FC RID: 6396
	private DateTime e;

	// Token: 0x040018FD RID: 6397
	private aia f;

	// Token: 0x040018FE RID: 6398
	public TypedObjectReference<efk> g;

	// Token: 0x040018FF RID: 6399
	public a3s h;

	// Token: 0x04001900 RID: 6400
	public string i;
}
