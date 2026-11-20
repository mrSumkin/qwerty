using System;
using System.Runtime.Serialization;

namespace Ouroboros.Common.Data
{
	// Token: 0x02000260 RID: 608
	[eiz("TOR")]
	[Serializable]
	public abstract class TypedObjectReference<T> : a3s, ISerializable where T : class
	{
		// Token: 0x06001173 RID: 4467 RVA: 0x00047EB8 File Offset: 0x000460B8
		protected TypedObjectReference(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.b() != 0)
			{
				if (base.GetType().Name == "FeatReference" && ell.a() < 17)
				{
					return;
				}
				this.b = (Guid?)A_0.GetValue("TOR:OI", typeof(Guid?));
				this.c = A_0.GetString("TOR:N");
				return;
			}
			else
			{
				if (base.GetType() == typeof(TypedObjectReference<T>))
				{
					this.b = (Guid?)A_0.GetValue("_ObjectId", typeof(Guid?));
					this.c = A_0.GetString("_Name");
					return;
				}
				this.b = (Guid?)A_0.GetValue("TypedObjectReference`1+_ObjectId", typeof(Guid?));
				this.c = A_0.GetString("TypedObjectReference`1+_Name");
				return;
			}
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00047FAC File Offset: 0x000461AC
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("TOR:OI", this.b);
			info.AddValue("TOR:N", this.c);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00047FD8 File Offset: 0x000461D8
		public T ao()
		{
			if (!this.d)
			{
				this.a = this.h4();
				this.d = true;
			}
			return this.a;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00048000 File Offset: 0x00046200
		public void a(T A_0)
		{
			this.a = A_0;
			this.d = true;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00048010 File Offset: 0x00046210
		public object afk()
		{
			return this.ao();
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00048020 File Offset: 0x00046220
		public Guid? afl()
		{
			return this.b;
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00048028 File Offset: 0x00046228
		public void a(Guid? A_0)
		{
			this.b = A_0;
			this.d = false;
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00048038 File Offset: 0x00046238
		public string y8()
		{
			return this.c;
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00048040 File Offset: 0x00046240
		public void b(string A_0)
		{
			this.c = A_0;
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0004804C File Offset: 0x0004624C
		public TypedObjectReference()
		{
		}

		// Token: 0x0600117D RID: 4477
		protected abstract T h4();

		// Token: 0x040009DC RID: 2524
		[NonSerialized]
		private T a;

		// Token: 0x040009DD RID: 2525
		private Guid? b;

		// Token: 0x040009DE RID: 2526
		private string c;

		// Token: 0x040009DF RID: 2527
		[NonSerialized]
		private bool d;
	}
}
