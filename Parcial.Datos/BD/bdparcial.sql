PGDMP                     
    y            parcial    13.2    13.2     ?           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ?           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ?           1262    108837    parcial    DATABASE     f   CREATE DATABASE parcial WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Spanish_Colombia.1252';
    DROP DATABASE parcial;
                postgres    false            ?            1259    108854    usuario    TABLE     n   CREATE TABLE public.usuario (
    id integer NOT NULL,
    nombre text NOT NULL,
    edad integer NOT NULL
);
    DROP TABLE public.usuario;
       public         heap    postgres    false            ?            1259    108852    usuario_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.usuario_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.usuario_id_seq;
       public          postgres    false    201            ?           0    0    usuario_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.usuario_id_seq OWNED BY public.usuario.id;
          public          postgres    false    200            #           2604    108857 
   usuario id    DEFAULT     h   ALTER TABLE ONLY public.usuario ALTER COLUMN id SET DEFAULT nextval('public.usuario_id_seq'::regclass);
 9   ALTER TABLE public.usuario ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    200    201    201            ?          0    108854    usuario 
   TABLE DATA           3   COPY public.usuario (id, nombre, edad) FROM stdin;
    public          postgres    false    201   C
       ?           0    0    usuario_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.usuario_id_seq', 2, true);
          public          postgres    false    200            %           2606    108862    usuario usuario_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.usuario DROP CONSTRAINT usuario_pkey;
       public            postgres    false    201            ?   #   x?3??J?M-?43?2?L?LM??42?????? `?+     